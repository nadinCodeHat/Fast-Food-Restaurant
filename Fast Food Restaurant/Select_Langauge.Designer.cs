
namespace Fast_Food_Restaurant
{
    partial class Select_Langauge
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
            this.englishBtn = new System.Windows.Forms.Button();
            this.frenchBtn = new System.Windows.Forms.Button();
            this.germanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // englishBtn
            // 
            this.englishBtn.Location = new System.Drawing.Point(82, 53);
            this.englishBtn.Name = "englishBtn";
            this.englishBtn.Size = new System.Drawing.Size(201, 23);
            this.englishBtn.TabIndex = 0;
            this.englishBtn.Text = "English";
            this.englishBtn.UseVisualStyleBackColor = true;
            // 
            // frenchBtn
            // 
            this.frenchBtn.Location = new System.Drawing.Point(82, 99);
            this.frenchBtn.Name = "frenchBtn";
            this.frenchBtn.Size = new System.Drawing.Size(201, 23);
            this.frenchBtn.TabIndex = 1;
            this.frenchBtn.Text = "French";
            this.frenchBtn.UseVisualStyleBackColor = true;
            // 
            // germanBtn
            // 
            this.germanBtn.Location = new System.Drawing.Point(82, 145);
            this.germanBtn.Name = "germanBtn";
            this.germanBtn.Size = new System.Drawing.Size(201, 23);
            this.germanBtn.TabIndex = 2;
            this.germanBtn.Text = "German";
            this.germanBtn.UseVisualStyleBackColor = true;
            // 
            // Select_Langauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 221);
            this.Controls.Add(this.germanBtn);
            this.Controls.Add(this.frenchBtn);
            this.Controls.Add(this.englishBtn);
            this.Name = "Select_Langauge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a Langauge";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button englishBtn;
        private System.Windows.Forms.Button frenchBtn;
        private System.Windows.Forms.Button germanBtn;
    }
}