
namespace Fast_Food_Restaurant
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.foodIdLabel = new System.Windows.Forms.Label();
            this.foodIdTextBox = new System.Windows.Forms.TextBox();
            this.sizecomboBox = new System.Windows.Forms.ComboBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.foodTable = new System.Windows.Forms.DataGridView();
            this.foodNameTextBox = new System.Windows.Forms.TextBox();
            this.foodNameLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.cuisineLabel = new System.Windows.Forms.Label();
            this.cuisinecomboBox = new System.Windows.Forms.ComboBox();
            this.foodpictureBox = new System.Windows.Forms.PictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.byId = new System.Windows.Forms.RadioButton();
            this.byName = new System.Windows.Forms.RadioButton();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.foodItemsTable = new System.Windows.Forms.DataGridView();
            this.totalLabel = new System.Windows.Forms.Label();
            this.itemCount = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.filterbycuisineLabel = new System.Windows.Forms.Label();
            this.filterByCuisine = new System.Windows.Forms.ComboBox();
            this.cuisineTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.foodTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodItemsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuisineTable)).BeginInit();
            this.SuspendLayout();
            // 
            // foodIdLabel
            // 
            this.foodIdLabel.AutoSize = true;
            this.foodIdLabel.Location = new System.Drawing.Point(12, 9);
            this.foodIdLabel.Name = "foodIdLabel";
            this.foodIdLabel.Size = new System.Drawing.Size(46, 13);
            this.foodIdLabel.TabIndex = 0;
            this.foodIdLabel.Text = "Food Id:";
            // 
            // foodIdTextBox
            // 
            this.foodIdTextBox.Location = new System.Drawing.Point(83, 6);
            this.foodIdTextBox.Name = "foodIdTextBox";
            this.foodIdTextBox.ReadOnly = true;
            this.foodIdTextBox.Size = new System.Drawing.Size(193, 20);
            this.foodIdTextBox.TabIndex = 1;
            // 
            // sizecomboBox
            // 
            this.sizecomboBox.FormattingEnabled = true;
            this.sizecomboBox.Location = new System.Drawing.Point(83, 84);
            this.sizecomboBox.Name = "sizecomboBox";
            this.sizecomboBox.Size = new System.Drawing.Size(193, 21);
            this.sizecomboBox.TabIndex = 2;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(189, 233);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(87, 23);
            this.browseBtn.TabIndex = 3;
            this.browseBtn.Text = "<<";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // foodTable
            // 
            this.foodTable.AllowUserToAddRows = false;
            this.foodTable.AllowUserToDeleteRows = false;
            this.foodTable.AllowUserToResizeColumns = false;
            this.foodTable.AllowUserToResizeRows = false;
            this.foodTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodTable.Location = new System.Drawing.Point(285, 32);
            this.foodTable.Name = "foodTable";
            this.foodTable.RowTemplate.ReadOnly = true;
            this.foodTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodTable.Size = new System.Drawing.Size(557, 185);
            this.foodTable.TabIndex = 4;
            this.foodTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodTable_CellClick);
            // 
            // foodNameTextBox
            // 
            this.foodNameTextBox.Location = new System.Drawing.Point(83, 32);
            this.foodNameTextBox.Name = "foodNameTextBox";
            this.foodNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.foodNameTextBox.TabIndex = 6;
            // 
            // foodNameLabel
            // 
            this.foodNameLabel.AutoSize = true;
            this.foodNameLabel.Location = new System.Drawing.Point(12, 35);
            this.foodNameLabel.Name = "foodNameLabel";
            this.foodNameLabel.Size = new System.Drawing.Size(65, 13);
            this.foodNameLabel.TabIndex = 5;
            this.foodNameLabel.Text = "Food Name:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(83, 58);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(193, 20);
            this.priceTextBox.TabIndex = 8;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 61);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Price:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(12, 87);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.sizeLabel.TabIndex = 9;
            this.sizeLabel.Text = "Size:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(83, 111);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(193, 65);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 114);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description:";
            // 
            // cuisineLabel
            // 
            this.cuisineLabel.AutoSize = true;
            this.cuisineLabel.Location = new System.Drawing.Point(12, 199);
            this.cuisineLabel.Name = "cuisineLabel";
            this.cuisineLabel.Size = new System.Drawing.Size(44, 13);
            this.cuisineLabel.TabIndex = 12;
            this.cuisineLabel.Text = "Cuisine:";
            // 
            // cuisinecomboBox
            // 
            this.cuisinecomboBox.FormattingEnabled = true;
            this.cuisinecomboBox.Location = new System.Drawing.Point(83, 196);
            this.cuisinecomboBox.Name = "cuisinecomboBox";
            this.cuisinecomboBox.Size = new System.Drawing.Size(193, 21);
            this.cuisinecomboBox.TabIndex = 13;
            // 
            // foodpictureBox
            // 
            this.foodpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodpictureBox.Location = new System.Drawing.Point(15, 233);
            this.foodpictureBox.Name = "foodpictureBox";
            this.foodpictureBox.Size = new System.Drawing.Size(155, 130);
            this.foodpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foodpictureBox.TabIndex = 14;
            this.foodpictureBox.TabStop = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(282, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(44, 13);
            this.searchLabel.TabIndex = 15;
            this.searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(332, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(193, 20);
            this.searchTextBox.TabIndex = 16;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // byId
            // 
            this.byId.AutoSize = true;
            this.byId.Checked = true;
            this.byId.Location = new System.Drawing.Point(548, 7);
            this.byId.Name = "byId";
            this.byId.Size = new System.Drawing.Size(50, 17);
            this.byId.TabIndex = 17;
            this.byId.TabStop = true;
            this.byId.Text = "by ID";
            this.byId.UseVisualStyleBackColor = true;
            // 
            // byName
            // 
            this.byName.AutoSize = true;
            this.byName.Location = new System.Drawing.Point(622, 7);
            this.byName.Name = "byName";
            this.byName.Size = new System.Drawing.Size(64, 17);
            this.byName.TabIndex = 18;
            this.byName.Text = "byName";
            this.byName.UseVisualStyleBackColor = true;
            // 
            // summaryBtn
            // 
            this.summaryBtn.Location = new System.Drawing.Point(285, 233);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(87, 23);
            this.summaryBtn.TabIndex = 19;
            this.summaryBtn.Text = "Summary";
            this.summaryBtn.UseVisualStyleBackColor = true;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // foodItemsTable
            // 
            this.foodItemsTable.AllowUserToAddRows = false;
            this.foodItemsTable.AllowUserToDeleteRows = false;
            this.foodItemsTable.AllowUserToResizeColumns = false;
            this.foodItemsTable.AllowUserToResizeRows = false;
            this.foodItemsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodItemsTable.Location = new System.Drawing.Point(391, 233);
            this.foodItemsTable.Name = "foodItemsTable";
            this.foodItemsTable.Size = new System.Drawing.Size(451, 130);
            this.foodItemsTable.TabIndex = 20;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(297, 313);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 21;
            this.totalLabel.Text = "Total:";
            // 
            // itemCount
            // 
            this.itemCount.AutoSize = true;
            this.itemCount.Location = new System.Drawing.Point(337, 313);
            this.itemCount.Name = "itemCount";
            this.itemCount.Size = new System.Drawing.Size(13, 13);
            this.itemCount.TabIndex = 22;
            this.itemCount.Text = "0";
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(15, 413);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(261, 38);
            this.insertBtn.TabIndex = 23;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(15, 459);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(261, 38);
            this.updateBtn.TabIndex = 24;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(15, 505);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(261, 38);
            this.deleteBtn.TabIndex = 25;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // filterbycuisineLabel
            // 
            this.filterbycuisineLabel.AutoSize = true;
            this.filterbycuisineLabel.Location = new System.Drawing.Point(387, 381);
            this.filterbycuisineLabel.Name = "filterbycuisineLabel";
            this.filterbycuisineLabel.Size = new System.Drawing.Size(83, 13);
            this.filterbycuisineLabel.TabIndex = 26;
            this.filterbycuisineLabel.Text = "Filter by Cuisine:";
            // 
            // filterByCuisine
            // 
            this.filterByCuisine.FormattingEnabled = true;
            this.filterByCuisine.Location = new System.Drawing.Point(476, 378);
            this.filterByCuisine.Name = "filterByCuisine";
            this.filterByCuisine.Size = new System.Drawing.Size(193, 21);
            this.filterByCuisine.TabIndex = 27;
            this.filterByCuisine.SelectedIndexChanged += new System.EventHandler(this.filterByCuisine_SelectedIndexChanged);
            // 
            // cuisineTable
            // 
            this.cuisineTable.AllowUserToAddRows = false;
            this.cuisineTable.AllowUserToDeleteRows = false;
            this.cuisineTable.AllowUserToResizeColumns = false;
            this.cuisineTable.AllowUserToResizeRows = false;
            this.cuisineTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cuisineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuisineTable.Location = new System.Drawing.Point(391, 413);
            this.cuisineTable.Name = "cuisineTable";
            this.cuisineTable.Size = new System.Drawing.Size(451, 130);
            this.cuisineTable.TabIndex = 28;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 555);
            this.Controls.Add(this.cuisineTable);
            this.Controls.Add(this.filterByCuisine);
            this.Controls.Add(this.filterbycuisineLabel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.itemCount);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.foodItemsTable);
            this.Controls.Add(this.summaryBtn);
            this.Controls.Add(this.byName);
            this.Controls.Add(this.byId);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.foodpictureBox);
            this.Controls.Add(this.cuisinecomboBox);
            this.Controls.Add(this.cuisineLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.foodNameTextBox);
            this.Controls.Add(this.foodNameLabel);
            this.Controls.Add(this.foodTable);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.sizecomboBox);
            this.Controls.Add(this.foodIdTextBox);
            this.Controls.Add(this.foodIdLabel);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Food Restaurant";
            this.Load += new System.EventHandler(this.App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodItemsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuisineTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodIdLabel;
        private System.Windows.Forms.TextBox foodIdTextBox;
        private System.Windows.Forms.ComboBox sizecomboBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.DataGridView foodTable;
        private System.Windows.Forms.TextBox foodNameTextBox;
        private System.Windows.Forms.Label foodNameLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label cuisineLabel;
        private System.Windows.Forms.ComboBox cuisinecomboBox;
        private System.Windows.Forms.PictureBox foodpictureBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton byId;
        private System.Windows.Forms.RadioButton byName;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.DataGridView foodItemsTable;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label itemCount;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label filterbycuisineLabel;
        private System.Windows.Forms.ComboBox filterByCuisine;
        private System.Windows.Forms.DataGridView cuisineTable;
    }
}

