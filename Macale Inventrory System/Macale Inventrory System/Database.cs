using System.Data.OleDb;
using System.Security.Cryptography;

namespace Macale_Inventrory_System;

internal static class Database
{
    private static string DatabasePath => FindDatabasePath();
    private static string ConnectionString =>
        $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath};Persist Security Info=False;";

    private static string FindDatabasePath()
    {
        DirectoryInfo? directory = new(AppContext.BaseDirectory);
        string? lastFoundPath = null;

        while (directory != null)
        {
            string candidate = Path.Combine(directory.FullName, "macaledb.accdb");
            if (File.Exists(candidate))
            {
                lastFoundPath = candidate;
            }

            directory = directory.Parent;
        }

        return lastFoundPath ?? Path.Combine(AppContext.BaseDirectory, "macaledb.accdb");
    }

    public static void EnsureUsersTable()
    {
        if (!File.Exists(DatabasePath))
        {
            throw new FileNotFoundException($"The Access database was not found at:{Environment.NewLine}{DatabasePath}");
        }

        using OleDbConnection connection = new(ConnectionString);
        connection.Open();

        try
        {
            using OleDbCommand command = new(
                "CREATE TABLE Users (UserID AUTOINCREMENT PRIMARY KEY, FullName VARCHAR(150), Username VARCHAR(100) NOT NULL, PasswordHash LONGTEXT, PasswordSalt LONGTEXT, UserRole VARCHAR(50), IsActive YESNO)",
                connection);
            command.ExecuteNonQuery();
        }
        catch (OleDbException)
        {
        }

        try
        {
            using OleDbCommand command = new("SELECT TOP 1 PasswordSalt FROM Users", connection);
            command.ExecuteScalar();
        }
        catch (OleDbException)
        {
            using OleDbCommand command = new("ALTER TABLE Users ADD COLUMN PasswordSalt LONGTEXT", connection);
            command.ExecuteNonQuery();
        }
    }

    public static bool RegisterUser(string fullName, string username, string password, out string message)
    {
        EnsureUsersTable();
        fullName = fullName.Trim();
        username = username.Trim();

        if (fullName.Length == 0 || username.Length == 0 || password.Length == 0)
        {
            message = "All fields are required.";
            return false;
        }

        using OleDbConnection connection = new(ConnectionString);
        connection.Open();

        using (OleDbCommand existsCommand = new("SELECT COUNT(*) FROM Users WHERE Username = ?", connection))
        {
            existsCommand.Parameters.AddWithValue("@username", username);
            if (Convert.ToInt32(existsCommand.ExecuteScalar()) > 0)
            {
                message = "That username is already registered.";
                return false;
            }
        }

        byte[] salt = RandomNumberGenerator.GetBytes(16);
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, 100_000, HashAlgorithmName.SHA256, 32);

        using OleDbCommand insertCommand = new(
            "INSERT INTO Users (FullName, Username, PasswordHash, PasswordSalt, UserRole, IsActive) VALUES (?, ?, ?, ?, ?, ?)",
            connection);
        insertCommand.Parameters.AddWithValue("@fullName", fullName);
        insertCommand.Parameters.AddWithValue("@username", username);
        insertCommand.Parameters.AddWithValue("@hash", Convert.ToBase64String(hash));
        insertCommand.Parameters.AddWithValue("@salt", Convert.ToBase64String(salt));
        insertCommand.Parameters.AddWithValue("@role", "User");
        insertCommand.Parameters.AddWithValue("@active", true);
        insertCommand.ExecuteNonQuery();

        message = "Registration successful!";
        return true;
    }

    public static bool ValidateUser(string username, string password, out string message)
    {
        EnsureUsersTable();
        username = username.Trim();

        using OleDbConnection connection = new(ConnectionString);
        connection.Open();
        using OleDbCommand command = new(
            "SELECT PasswordHash, PasswordSalt FROM Users WHERE Username = ? AND IsActive = True",
            connection);
        command.Parameters.AddWithValue("@username", username);

        using OleDbDataReader reader = command.ExecuteReader();
        if (reader == null || !reader.Read())
        {
            message = "Invalid username or password.";
            return false;
        }

        string storedHash = reader["PasswordHash"]?.ToString() ?? string.Empty;
        string storedSalt = reader["PasswordSalt"]?.ToString() ?? string.Empty;
        byte[] salt = Convert.FromBase64String(storedSalt);
        byte[] expectedHash = Convert.FromBase64String(storedHash);
        byte[] suppliedHash = Rfc2898DeriveBytes.Pbkdf2(password, salt, 100_000, HashAlgorithmName.SHA256, 32);

        bool valid = CryptographicOperations.FixedTimeEquals(expectedHash, suppliedHash);
        message = valid ? string.Empty : "Invalid username or password.";
        return valid;
    }
}
