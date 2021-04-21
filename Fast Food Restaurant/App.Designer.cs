
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.byId = new System.Windows.Forms.RadioButton();
            this.byName = new System.Windows.Forms.RadioButton();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.filterbycuisineLabel = new System.Windows.Forms.Label();
            this.filterbycuisinecomboBox = new System.Windows.Forms.ComboBox();
            this.cuisineTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.foodTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // foodTable
            // 
            this.foodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodTable.Location = new System.Drawing.Point(285, 32);
            this.foodTable.Name = "foodTable";
            this.foodTable.Size = new System.Drawing.Size(557, 185);
            this.foodTable.TabIndex = 4;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 130);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
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
            // 
            // byId
            // 
            this.byId.AutoSize = true;
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
            this.byName.TabStop = true;
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
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(391, 233);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(451, 130);
            this.dataGridView2.TabIndex = 20;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "label9";
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(15, 413);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(261, 38);
            this.insertBtn.TabIndex = 23;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(15, 459);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(261, 38);
            this.updateBtn.TabIndex = 24;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(15, 505);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(261, 38);
            this.deleteBtn.TabIndex = 25;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
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
            // filterbycuisinecomboBox
            // 
            this.filterbycuisinecomboBox.FormattingEnabled = true;
            this.filterbycuisinecomboBox.Location = new System.Drawing.Point(476, 378);
            this.filterbycuisinecomboBox.Name = "filterbycuisinecomboBox";
            this.filterbycuisinecomboBox.Size = new System.Drawing.Size(193, 21);
            this.filterbycuisinecomboBox.TabIndex = 27;
            // 
            // cuisineTable
            // 
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
            this.Controls.Add(this.filterbycuisinecomboBox);
            this.Controls.Add(this.filterbycuisineLabel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.summaryBtn);
            this.Controls.Add(this.byName);
            this.Controls.Add(this.byId);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sizecomboBox);
            this.Controls.Add(this.foodIdTextBox);
            this.Controls.Add(this.foodIdLabel);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Food Restaurant";
            ((System.ComponentModel.ISupportInitialize)(this.foodTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuisineTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodIdLabel;
        private System.Windows.Forms.TextBox foodIdTextBox;
        private System.Windows.Forms.ComboBox sizecomboBox;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton byId;
        private System.Windows.Forms.RadioButton byName;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label filterbycuisineLabel;
        private System.Windows.Forms.ComboBox filterbycuisinecomboBox;
        private System.Windows.Forms.DataGridView cuisineTable;
    }
}

