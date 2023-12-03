namespace MarketYönetimSistemi
{
    partial class AddProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.StockTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CategoryCb = new System.Windows.Forms.ComboBox();
            this.IsDeleteCb = new System.Windows.Forms.CheckBox();
            this.IsStatusCb = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(81, 12);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 20);
            this.NameTxt.TabIndex = 1;
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Location = new System.Drawing.Point(81, 55);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(100, 20);
            this.DescriptionTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(81, 105);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(100, 20);
            this.PriceTxt.TabIndex = 5;
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Location = new System.Drawing.Point(23, 108);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(31, 13);
            this.Pricelbl.TabIndex = 4;
            this.Pricelbl.Text = "Price";
            // 
            // StockTxt
            // 
            this.StockTxt.Location = new System.Drawing.Point(81, 150);
            this.StockTxt.Name = "StockTxt";
            this.StockTxt.Size = new System.Drawing.Size(100, 20);
            this.StockTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category";
            // 
            // CategoryCb
            // 
            this.CategoryCb.FormattingEnabled = true;
            this.CategoryCb.Location = new System.Drawing.Point(81, 188);
            this.CategoryCb.Name = "CategoryCb";
            this.CategoryCb.Size = new System.Drawing.Size(100, 21);
            this.CategoryCb.TabIndex = 13;
            // 
            // IsDeleteCb
            // 
            this.IsDeleteCb.AutoSize = true;
            this.IsDeleteCb.Location = new System.Drawing.Point(81, 230);
            this.IsDeleteCb.Name = "IsDeleteCb";
            this.IsDeleteCb.Size = new System.Drawing.Size(65, 17);
            this.IsDeleteCb.TabIndex = 14;
            this.IsDeleteCb.Text = "IsDelete";
            this.IsDeleteCb.UseVisualStyleBackColor = true;
            // 
            // IsStatusCb
            // 
            this.IsStatusCb.AutoSize = true;
            this.IsStatusCb.Location = new System.Drawing.Point(81, 263);
            this.IsStatusCb.Name = "IsStatusCb";
            this.IsStatusCb.Size = new System.Drawing.Size(64, 17);
            this.IsStatusCb.TabIndex = 15;
            this.IsStatusCb.Text = "IsStatus";
            this.IsStatusCb.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Choose Img";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(216, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(216, 237);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(158, 43);
            this.AddProductBtn.TabIndex = 18;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(408, 368);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IsStatusCb);
            this.Controls.Add(this.IsDeleteCb);
            this.Controls.Add(this.CategoryCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StockTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddProductForm_FormClosed);
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.TextBox StockTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CategoryCb;
        private System.Windows.Forms.CheckBox IsDeleteCb;
        private System.Windows.Forms.CheckBox IsStatusCb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddProductBtn;
    }
}