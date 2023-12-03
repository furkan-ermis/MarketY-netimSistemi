namespace MarketYönetimSistemi
{
    partial class ProductDetailForm
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.StockLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.Label();
            this.CategoryTxt = new System.Windows.Forms.Label();
            this.StockTxt = new System.Windows.Forms.Label();
            this.PriceTxt = new System.Windows.Forms.Label();
            this.detailPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.detailPb)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.NameLbl.Location = new System.Drawing.Point(212, 53);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(50, 21);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Ürün";
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.CategoryLbl.Location = new System.Drawing.Point(212, 90);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(76, 21);
            this.CategoryLbl.TabIndex = 2;
            this.CategoryLbl.Text = "Category";
            // 
            // StockLbl
            // 
            this.StockLbl.AutoSize = true;
            this.StockLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.StockLbl.Location = new System.Drawing.Point(212, 126);
            this.StockLbl.Name = "StockLbl";
            this.StockLbl.Size = new System.Drawing.Size(53, 21);
            this.StockLbl.TabIndex = 3;
            this.StockLbl.Text = "Stock";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.PriceLbl.Location = new System.Drawing.Point(212, 160);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(51, 21);
            this.PriceLbl.TabIndex = 4;
            this.PriceLbl.Text = "Price";
            // 
            // NameTxt
            // 
            this.NameTxt.AutoSize = true;
            this.NameTxt.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(299, 53);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(0, 24);
            this.NameTxt.TabIndex = 5;
            // 
            // CategoryTxt
            // 
            this.CategoryTxt.AutoSize = true;
            this.CategoryTxt.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTxt.Location = new System.Drawing.Point(299, 90);
            this.CategoryTxt.Name = "CategoryTxt";
            this.CategoryTxt.Size = new System.Drawing.Size(0, 24);
            this.CategoryTxt.TabIndex = 6;
            // 
            // StockTxt
            // 
            this.StockTxt.AutoSize = true;
            this.StockTxt.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTxt.Location = new System.Drawing.Point(299, 126);
            this.StockTxt.Name = "StockTxt";
            this.StockTxt.Size = new System.Drawing.Size(0, 24);
            this.StockTxt.TabIndex = 7;
            // 
            // PriceTxt
            // 
            this.PriceTxt.AutoSize = true;
            this.PriceTxt.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTxt.Location = new System.Drawing.Point(299, 160);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(0, 24);
            this.PriceTxt.TabIndex = 8;
            // 
            // detailPb
            // 
            this.detailPb.Location = new System.Drawing.Point(12, 43);
            this.detailPb.Name = "detailPb";
            this.detailPb.Size = new System.Drawing.Size(194, 159);
            this.detailPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.detailPb.TabIndex = 0;
            this.detailPb.TabStop = false;
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(462, 293);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.StockTxt);
            this.Controls.Add(this.CategoryTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.StockLbl);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.detailPb);
            this.Name = "ProductDetailForm";
            this.Text = "ProductDetailForm";
            this.Load += new System.EventHandler(this.ProductDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox detailPb;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label StockLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label NameTxt;
        private System.Windows.Forms.Label CategoryTxt;
        private System.Windows.Forms.Label StockTxt;
        private System.Windows.Forms.Label PriceTxt;
    }
}