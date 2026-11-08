namespace Macale_Inventrory_System
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel = null!;
        private Panel sidebarPanel = null!;
        private Panel contentPanel = null!;
        private Label brandIconLabel = null!;
        private Label brandLabel = null!;
        private Label pageTitleLabel = null!;
        private Label pageSubtitleLabel = null!;
        private Label productListLabel = null!;
        private Label productNameLabel = null!;
        private Label categoryLabel = null!;
        private Label quantityLabel = null!;
        private Label priceLabel = null!;
        private Label navInventoryLabel = null!;
        private Label navDashboardLabel = null!;
        private Label navProductsLabel = null!;
        private Label navCategoriesLabel = null!;
        private Label navReportsLabel = null!;
        private TextBox productNameTextBox = null!;
        private ComboBox categoryComboBox = null!;
        private NumericUpDown quantityTextBox = null!;
        private NumericUpDown priceTextBox = null!;
        private TextBox searchTextBox = null!;
        private Button createButton = null!;
        private DataGridView productsGrid = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            brandIconLabel = new Label();
            brandLabel = new Label();
            sidebarPanel = new Panel();
            navInventoryLabel = new Label();
            navDashboardLabel = new Label();
            navProductsLabel = new Label();
            navCategoriesLabel = new Label();
            navReportsLabel = new Label();
            contentPanel = new Panel();
            pageTitleLabel = new Label();
            pageSubtitleLabel = new Label();
            productListLabel = new Label();
            productNameLabel = new Label();
            productNameTextBox = new TextBox();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            quantityLabel = new Label();
            quantityTextBox = new NumericUpDown();
            priceLabel = new Label();
            priceTextBox = new NumericUpDown();
            createButton = new Button();
            searchTextBox = new TextBox();
            productsGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            headerPanel.SuspendLayout();
            sidebarPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(8, 8, 125);
            headerPanel.Controls.Add(brandIconLabel);
            headerPanel.Controls.Add(brandLabel);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(800, 57);
            headerPanel.TabIndex = 2;
            // 
            // brandIconLabel
            // 
            brandIconLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            brandIconLabel.ForeColor = Color.FromArgb(0, 242, 255);
            brandIconLabel.Location = new Point(10, 8);
            brandIconLabel.Name = "brandIconLabel";
            brandIconLabel.Size = new Size(42, 42);
            brandIconLabel.TabIndex = 0;
            brandIconLabel.Text = "■";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            brandLabel.ForeColor = Color.White;
            brandLabel.Location = new Point(58, 17);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(309, 28);
            brandLabel.TabIndex = 1;
            brandLabel.Text = "Inventory Management System";
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(17, 18, 106);
            sidebarPanel.Controls.Add(navInventoryLabel);
            sidebarPanel.Controls.Add(navDashboardLabel);
            sidebarPanel.Controls.Add(navProductsLabel);
            sidebarPanel.Controls.Add(navCategoriesLabel);
            sidebarPanel.Controls.Add(navReportsLabel);
            sidebarPanel.Location = new Point(0, 57);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(150, 443);
            sidebarPanel.TabIndex = 1;
            // 
            // navInventoryLabel
            // 
            navInventoryLabel.BackColor = Color.FromArgb(21, 136, 232);
            navInventoryLabel.Font = new Font("Segoe UI", 9F);
            navInventoryLabel.ForeColor = Color.White;
            navInventoryLabel.Location = new Point(8, 9);
            navInventoryLabel.Name = "navInventoryLabel";
            navInventoryLabel.Padding = new Padding(12, 0, 0, 0);
            navInventoryLabel.Size = new Size(134, 39);
            navInventoryLabel.TabIndex = 0;
            navInventoryLabel.Text = "Inventory";
            navInventoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // navDashboardLabel
            // 
            navDashboardLabel.BackColor = Color.FromArgb(21, 136, 232);
            navDashboardLabel.Font = new Font("Segoe UI", 9F);
            navDashboardLabel.ForeColor = Color.White;
            navDashboardLabel.Location = new Point(8, 50);
            navDashboardLabel.Name = "navDashboardLabel";
            navDashboardLabel.Padding = new Padding(12, 0, 0, 0);
            navDashboardLabel.Size = new Size(134, 39);
            navDashboardLabel.TabIndex = 1;
            navDashboardLabel.Text = "Dashboard";
            navDashboardLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // navProductsLabel
            // 
            navProductsLabel.BackColor = Color.FromArgb(21, 136, 232);
            navProductsLabel.Font = new Font("Segoe UI", 9F);
            navProductsLabel.ForeColor = Color.White;
            navProductsLabel.Location = new Point(8, 91);
            navProductsLabel.Name = "navProductsLabel";
            navProductsLabel.Padding = new Padding(12, 0, 0, 0);
            navProductsLabel.Size = new Size(134, 39);
            navProductsLabel.TabIndex = 2;
            navProductsLabel.Text = "Products";
            navProductsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // navCategoriesLabel
            // 
            navCategoriesLabel.BackColor = Color.FromArgb(21, 136, 232);
            navCategoriesLabel.Font = new Font("Segoe UI", 9F);
            navCategoriesLabel.ForeColor = Color.White;
            navCategoriesLabel.Location = new Point(8, 132);
            navCategoriesLabel.Name = "navCategoriesLabel";
            navCategoriesLabel.Padding = new Padding(12, 0, 0, 0);
            navCategoriesLabel.Size = new Size(134, 39);
            navCategoriesLabel.TabIndex = 3;
            navCategoriesLabel.Text = "Categories";
            navCategoriesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // navReportsLabel
            // 
            navReportsLabel.BackColor = Color.FromArgb(21, 136, 232);
            navReportsLabel.Font = new Font("Segoe UI", 9F);
            navReportsLabel.ForeColor = Color.White;
            navReportsLabel.Location = new Point(8, 173);
            navReportsLabel.Name = "navReportsLabel";
            navReportsLabel.Padding = new Padding(12, 0, 0, 0);
            navReportsLabel.Size = new Size(134, 39);
            navReportsLabel.TabIndex = 4;
            navReportsLabel.Text = "Reports";
            navReportsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.Controls.Add(pageTitleLabel);
            contentPanel.Controls.Add(pageSubtitleLabel);
            contentPanel.Controls.Add(productListLabel);
            contentPanel.Controls.Add(productNameLabel);
            contentPanel.Controls.Add(productNameTextBox);
            contentPanel.Controls.Add(categoryLabel);
            contentPanel.Controls.Add(categoryComboBox);
            contentPanel.Controls.Add(quantityLabel);
            contentPanel.Controls.Add(quantityTextBox);
            contentPanel.Controls.Add(priceLabel);
            contentPanel.Controls.Add(priceTextBox);
            contentPanel.Controls.Add(createButton);
            contentPanel.Controls.Add(searchTextBox);
            contentPanel.Controls.Add(productsGrid);
            contentPanel.Location = new Point(150, 57);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(650, 443);
            contentPanel.TabIndex = 0;
            // 
            // pageTitleLabel
            // 
            pageTitleLabel.AutoSize = true;
            pageTitleLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            pageTitleLabel.ForeColor = Color.FromArgb(21, 27, 105);
            pageTitleLabel.Location = new Point(9, 4);
            pageTitleLabel.Name = "pageTitleLabel";
            pageTitleLabel.Size = new Size(165, 45);
            pageTitleLabel.TabIndex = 0;
            pageTitleLabel.Text = "Inventory";
            // 
            // pageSubtitleLabel
            // 
            pageSubtitleLabel.AutoSize = true;
            pageSubtitleLabel.Font = new Font("Segoe UI", 8F);
            pageSubtitleLabel.ForeColor = Color.Gray;
            pageSubtitleLabel.Location = new Point(13, 46);
            pageSubtitleLabel.Name = "pageSubtitleLabel";
            pageSubtitleLabel.Size = new Size(252, 19);
            pageSubtitleLabel.TabIndex = 1;
            pageSubtitleLabel.Text = "Manage your products and stock levels.";
            // 
            // productListLabel
            // 
            productListLabel.AutoSize = true;
            productListLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            productListLabel.ForeColor = Color.FromArgb(21, 27, 105);
            productListLabel.Location = new Point(8, 66);
            productListLabel.Name = "productListLabel";
            productListLabel.Size = new Size(171, 25);
            productListLabel.TabIndex = 2;
            productListLabel.Text = "Add New Product";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            productNameLabel.Location = new Point(10, 91);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(87, 15);
            productNameLabel.TabIndex = 3;
            productNameLabel.Text = "Product Name";
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(10, 113);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(112, 27);
            productNameTextBox.TabIndex = 4;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            categoryLabel.Location = new Point(126, 91);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(57, 15);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Location = new Point(126, 112);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(112, 28);
            categoryComboBox.TabIndex = 6;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            quantityLabel.Location = new Point(252, 90);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(55, 15);
            quantityLabel.TabIndex = 7;
            quantityLabel.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(252, 112);
            quantityTextBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(112, 27);
            quantityTextBox.TabIndex = 8;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            priceLabel.Location = new Point(378, 89);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(35, 15);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Price";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(378, 110);
            priceTextBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(112, 27);
            priceTextBox.TabIndex = 10;
            // 
            // createButton
            // 
            createButton.BackColor = Color.FromArgb(39, 174, 96);
            createButton.FlatAppearance.BorderSize = 0;
            createButton.FlatStyle = FlatStyle.Flat;
            createButton.ForeColor = Color.White;
            createButton.Location = new Point(502, 107);
            createButton.Name = "createButton";
            createButton.Size = new Size(62, 31);
            createButton.TabIndex = 11;
            createButton.Text = "+ Create";
            createButton.UseVisualStyleBackColor = false;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 7F);
            searchTextBox.Location = new Point(399, 142);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(164, 23);
            searchTextBox.TabIndex = 12;
            searchTextBox.Text = "Search products...";
            // 
            // productsGrid
            // 
            productsGrid.AllowUserToAddRows = false;
            productsGrid.AllowUserToResizeRows = false;
            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGrid.BackgroundColor = Color.White;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            productsGrid.Location = new Point(10, 171);
            productsGrid.Name = "productsGrid";
            productsGrid.RowHeadersVisible = false;
            productsGrid.RowHeadersWidth = 51;
            productsGrid.Size = new Size(554, 175);
            productsGrid.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Category";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Price";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Total Value";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Actions";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(877, 556);
            Controls.Add(contentPanel);
            Controls.Add(sidebarPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            sidebarPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
