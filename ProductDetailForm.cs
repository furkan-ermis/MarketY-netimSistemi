using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
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
    public partial class ProductDetailForm : Form
    {
        CategoryCrud categoryCrud = new CategoryCrud();
        private readonly Product _product;
        public ProductDetailForm(Product product)
        {
            InitializeComponent();
            _product= product;
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            detailPb.ImageLocation = _product.Image;
            NameTxt.Text = _product.Name;
            CategoryTxt.Text= categoryCrud.GetById(_product.CategoryId).Name;
            PriceTxt.Text = _product.Price.ToString();
            StockTxt.Text = _product.Stock.ToString();
        }
    }
}
