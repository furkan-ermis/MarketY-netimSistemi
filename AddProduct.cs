using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class AddProductForm : Form
    {
        CategoryCrud categoryCrud = new CategoryCrud();
        ProductCrud productCrud = new ProductCrud();
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                string name = openFileDialog.FileName;
                string[] fileName = name.Split('\\');
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            CategoryCb.DataSource = categoryCrud.GetAll();
            CategoryCb.DisplayMember = "Name";
            CategoryCb.ValueMember = "Id";
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product() {
                Name = NameTxt.Text,
                Description= DescriptionTxt.Text,
                Price=Convert.ToInt32(PriceTxt.Text),
                Stock=Convert.ToInt32(StockTxt.Text),
                CategoryId=Convert.ToInt32(CategoryCb.SelectedValue),
                IsStatus=IsStatusCb.Checked,
                IsDelete=IsDeleteCb.Checked,
                Image=pictureBox1.ImageLocation
            };
            productCrud.Add(product);
            DialogResult dialog=MessageBox.Show("Ürün Ekleme Başarılı", "Sepet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialog== DialogResult.OK)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
        }

        private void AddProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}
