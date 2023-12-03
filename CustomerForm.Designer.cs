namespace MarketYönetimSistemi
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.ProductListHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TitleLbl = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.Panel();
            this.ProductListHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductListHeader
            // 
            this.ProductListHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.ProductListHeader.Controls.Add(this.pictureBox1);
            this.ProductListHeader.Controls.Add(this.button1);
            this.ProductListHeader.Controls.Add(this.TitleLbl);
            this.ProductListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductListHeader.Location = new System.Drawing.Point(0, 0);
            this.ProductListHeader.Name = "ProductListHeader";
            this.ProductListHeader.Size = new System.Drawing.Size(817, 81);
            this.ProductListHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MarketYönetimSistemi.Properties.Resources.bizimManavLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "cart (2).png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(735, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 81);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cart.png");
            this.ımageList1.Images.SetKeyName(1, "cart (2).png");
            this.ımageList1.Images.SetKeyName(2, "cartAdd.png");
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(269, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(278, 38);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "ÜRÜNLERİMİZ";
            // 
            // ProductList
            // 
            this.ProductList.AutoScroll = true;
            this.ProductList.BackColor = System.Drawing.Color.SeaGreen;
            this.ProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductList.Location = new System.Drawing.Point(0, 81);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(817, 369);
            this.ProductList.TabIndex = 1;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.ProductListHeader);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.SizeChanged += new System.EventHandler(this.CustomerForm_SizeChanged);
            this.ProductListHeader.ResumeLayout(false);
            this.ProductListHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProductListHeader;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Panel ProductList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}