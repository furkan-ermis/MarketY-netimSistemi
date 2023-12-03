namespace MarketYönetimSistemi
{
    partial class CustomerCartForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCartForm));
            this.CartList = new System.Windows.Forms.Panel();
            this.BuyCartBtn = new System.Windows.Forms.Button();
            this.ProductListHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productsBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TitleLbl = new System.Windows.Forms.Label();
            this.CartList.SuspendLayout();
            this.ProductListHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CartList
            // 
            this.CartList.AutoScroll = true;
            this.CartList.BackColor = System.Drawing.Color.SeaGreen;
            this.CartList.Controls.Add(this.BuyCartBtn);
            this.CartList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartList.Location = new System.Drawing.Point(0, 81);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(776, 423);
            this.CartList.TabIndex = 3;
            // 
            // BuyCartBtn
            // 
            this.BuyCartBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.BuyCartBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BuyCartBtn.FlatAppearance.BorderSize = 0;
            this.BuyCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyCartBtn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyCartBtn.Location = new System.Drawing.Point(0, 342);
            this.BuyCartBtn.Name = "BuyCartBtn";
            this.BuyCartBtn.Size = new System.Drawing.Size(776, 81);
            this.BuyCartBtn.TabIndex = 2;
            this.BuyCartBtn.Text = "Satın Al";
            this.BuyCartBtn.UseVisualStyleBackColor = false;
            this.BuyCartBtn.Click += new System.EventHandler(this.BuyCartBtn_Click);
            // 
            // ProductListHeader
            // 
            this.ProductListHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.ProductListHeader.Controls.Add(this.pictureBox1);
            this.ProductListHeader.Controls.Add(this.productsBtn);
            this.ProductListHeader.Controls.Add(this.TitleLbl);
            this.ProductListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductListHeader.Location = new System.Drawing.Point(0, 0);
            this.ProductListHeader.Name = "ProductListHeader";
            this.ProductListHeader.Size = new System.Drawing.Size(776, 81);
            this.ProductListHeader.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.Color.Transparent;
            this.productsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.ImageKey = "shop.png";
            this.productsBtn.ImageList = this.ımageList1;
            this.productsBtn.Location = new System.Drawing.Point(709, 0);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(67, 81);
            this.productsBtn.TabIndex = 1;
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cart.png");
            this.ımageList1.Images.SetKeyName(1, "cart (2).png");
            this.ımageList1.Images.SetKeyName(2, "cartAdd.png");
            this.ımageList1.Images.SetKeyName(3, "shop.png");
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(328, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(142, 38);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Sepetim";
            // 
            // CustomerCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 504);
            this.Controls.Add(this.CartList);
            this.Controls.Add(this.ProductListHeader);
            this.Name = "CustomerCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerCartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerCartForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerCartForm_Load);
            this.SizeChanged += new System.EventHandler(this.CustomerCartForm_SizeChanged);
            this.CartList.ResumeLayout(false);
            this.ProductListHeader.ResumeLayout(false);
            this.ProductListHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CartList;
        private System.Windows.Forms.Panel ProductListHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button BuyCartBtn;
    }
}