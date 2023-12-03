using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class UpdateProduct : Form
    {
        CategoryCrud categoryCrud = new CategoryCrud();
        ProductCrud productCrud = new ProductCrud();
        private readonly Product _product;
        public UpdateProduct(Product product)
        {
            InitializeComponent();
            _product = product;
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

        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = NameTxt.Text,
                Description = DescriptionTxt.Text,
                Price = Convert.ToInt32(PriceTxt.Text),
                Stock = Convert.ToInt32(StockTxt.Text),
                CategoryId = Convert.ToInt32(CategoryCb.SelectedValue),
                IsStatus = IsStatusCb.Checked,
                IsDelete = IsDeleteCb.Checked,
                Image = pictureBox1.ImageLocation
            };
            productCrud.Update(product, _product.Id);
            DialogResult dialog = MessageBox.Show("Ürün Güncelleme Başarılı", "Sepet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            CategoryCb.DataSource = categoryCrud.GetAll();
            CategoryCb.DisplayMember = "Name";
            CategoryCb.ValueMember = "Id";

            NameTxt.Text = _product.Name;
            DescriptionTxt.Text = _product.Description;
            PriceTxt.Text = _product.Price.ToString();
            StockTxt.Text = _product.Stock.ToString();
            CategoryCb.SelectedValue = _product.CategoryId;
            IsStatusCb.Checked= _product.IsStatus;
            IsDeleteCb.Checked = _product.IsDelete;
            pictureBox1.ImageLocation = _product.Image;
        }

        private void UpdateProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm adminForm= new AdminForm();
            adminForm.Show();
            Dispose();

        }
    }
}
