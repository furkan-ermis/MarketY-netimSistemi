namespace MarketYönetimSistemi
{
    partial class RaportsForm
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
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.GetDataBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(12, 26);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 0;
            this.dateTimePickerStart.Value = new System.DateTime(2022, 12, 3, 23, 36, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(588, 26);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // GetDataBtn
            // 
            this.GetDataBtn.Location = new System.Drawing.Point(355, 27);
            this.GetDataBtn.Name = "GetDataBtn";
            this.GetDataBtn.Size = new System.Drawing.Size(75, 23);
            this.GetDataBtn.TabIndex = 2;
            this.GetDataBtn.Text = "Get Data";
            this.GetDataBtn.UseVisualStyleBackColor = true;
            this.GetDataBtn.Click += new System.EventHandler(this.GetDataBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 370);
            this.panel1.TabIndex = 3;
            // 
            // RaportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GetDataBtn);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Name = "RaportsForm";
            this.Text = "RaportsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RaportsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button GetDataBtn;
        private System.Windows.Forms.Panel panel1;
    }
}