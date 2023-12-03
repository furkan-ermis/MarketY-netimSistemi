namespace MarketYönetimSistemi
{
    partial class AdminForm
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.RaportsBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.ProductsBtn = new System.Windows.Forms.Button();
            this.AdminNameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MenuPanel.Controls.Add(this.RaportsBtn);
            this.MenuPanel.Controls.Add(this.button5);
            this.MenuPanel.Controls.Add(this.AddProductBtn);
            this.MenuPanel.Controls.Add(this.UsersBtn);
            this.MenuPanel.Controls.Add(this.ProductsBtn);
            this.MenuPanel.Controls.Add(this.AdminNameLbl);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(203, 450);
            this.MenuPanel.TabIndex = 0;
            // 
            // RaportsBtn
            // 
            this.RaportsBtn.BackColor = System.Drawing.Color.Gold;
            this.RaportsBtn.Location = new System.Drawing.Point(0, 372);
            this.RaportsBtn.Name = "RaportsBtn";
            this.RaportsBtn.Size = new System.Drawing.Size(203, 43);
            this.RaportsBtn.TabIndex = 5;
            this.RaportsBtn.Text = "RAPORLAR";
            this.RaportsBtn.UseVisualStyleBackColor = false;
            this.RaportsBtn.Click += new System.EventHandler(this.RaportsBtn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Chocolate;
            this.button5.Location = new System.Drawing.Point(0, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 43);
            this.button5.TabIndex = 6;
            this.button5.Text = "KULLANICI EKLE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AddProductBtn.Location = new System.Drawing.Point(0, 252);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(203, 43);
            this.AddProductBtn.TabIndex = 4;
            this.AddProductBtn.Text = "ÜRÜN EKLE";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.UsersBtn.Location = new System.Drawing.Point(0, 194);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(203, 43);
            this.UsersBtn.TabIndex = 3;
            this.UsersBtn.Text = "KULLANICILAR";
            this.UsersBtn.UseVisualStyleBackColor = false;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.BackColor = System.Drawing.Color.Tomato;
            this.ProductsBtn.Location = new System.Drawing.Point(0, 135);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Size = new System.Drawing.Size(203, 43);
            this.ProductsBtn.TabIndex = 2;
            this.ProductsBtn.Text = "ÜRÜNLER";
            this.ProductsBtn.UseVisualStyleBackColor = false;
            this.ProductsBtn.Click += new System.EventHandler(this.ProductsBtn_Click);
            // 
            // AdminNameLbl
            // 
            this.AdminNameLbl.AutoSize = true;
            this.AdminNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminNameLbl.Location = new System.Drawing.Point(40, 98);
            this.AdminNameLbl.Name = "AdminNameLbl";
            this.AdminNameLbl.Size = new System.Drawing.Size(0, 25);
            this.AdminNameLbl.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarketYönetimSistemi.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(46, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ListPanel
            // 
            this.ListPanel.AutoScroll = true;
            this.ListPanel.AutoSize = true;
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(203, 0);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(597, 450);
            this.ListPanel.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.SizeChanged += new System.EventHandler(this.AdminForm_SizeChanged);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button RaportsBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Button ProductsBtn;
        private System.Windows.Forms.Label AdminNameLbl;
    }
}