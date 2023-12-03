using MarketYönetimSistemi.Entity.Interface;
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
using MarketYönetimSistemi.Controller;

namespace MarketYönetimSistemi
{

    partial class CustomerCartForm : Form
    {
        SellProductCrud sellProductCrud = new SellProductCrud();
        CategoryCrud categoryCrud =new CategoryCrud();
        ProductCrud productCrud = new ProductCrud();
        OrderCrud orderCrud = new OrderCrud();
        private readonly Order _order;
        PictureBox ProductImgPb;
        Label ProductNameLbl;
        Label ProductQuantityLbl;
        Button RemoveCartBtn;
        GroupBox ProductGb;

        public CustomerCartForm(Order order)
        {
            InitializeComponent();
            _order = order;
        }

        private void CustomerCartForm_Load(object sender, EventArgs e)
        {
            TitleCenter();
            ProductListingIntoPanel();
        }
        private void TitleCenter()
        {
            int FormWidth = (this.Width / 2) - (TitleLbl.Width / 2);
            int PanelHeight = (ProductListHeader.Height / 2) - (TitleLbl.Height / 2);
            TitleLbl.Location = new Point(FormWidth, PanelHeight);
        }
        private void ProductListingIntoPanel()
        {
            int xStart = 20;
            int yStart = 20;
            int i = 0;
            int step = 170;
            int productGbCountPerRow = ((CartList.Width - xStart) - (CartList.Width - xStart) % step) / step;
            if (_order.IsStatus)
            {
                return;
            }
            foreach (var product in sellProductCrud.GetAll(_order.Id))
            {
                int _productId=sellProductCrud.GetById(product.Id).ProductId;
                if (productGbCountPerRow == i)
                {
                    yStart += step + 90;
                    i = 0;
                }
                ProductGb = new GroupBox()
                {
                    Name = "ProductGb_" + product.Id,
                    Text = categoryCrud.GetById(productCrud.GetById(product.ProductId).CategoryId).Name.ToString(),
                    Size = new Size(150, 240),
                    BackColor = Color.White,
                    Location = new Point(xStart + (step * i), yStart)
                };
                ProductImgPb = new PictureBox()
                {
                    Name = "ProductImgPb_" + product.Id,
                    Size = new Size(120, 80),
                    ImageLocation = productCrud.GetById(product.ProductId).Image,
                    Location = new Point(15, 15),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                ProductQuantityLbl = new Label()
                {
                    Name = "ProductQuantity_" + product.Id,
                    Text ="Adet : "+product.Quantity,
                    Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(120, 40),
                    Location = new Point(15, 135)
                };
                ProductNameLbl = new Label()
                {
                    Name = "ProductName_" + product.Id,
                    Text = productCrud.GetById(product.ProductId).Name.ToString(),
                    Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(120, 40),
                    Location = new Point(15, 155)
                };
                RemoveCartBtn = new Button()
                {
                    Name = "ProductCartBtn_" + product.Id,
                    Text = "Kaldır",
                    Location = new Point(15, 185),
                    Size = new Size(120, 40),
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                };
                RemoveCartBtn.Click += RemoveCartBtn_Click;
                ProductGb.Controls.Add(RemoveCartBtn);
                ProductGb.Controls.Add(ProductNameLbl);
                ProductGb.Controls.Add(ProductQuantityLbl);
                ProductGb.Controls.Add(ProductImgPb);
                CartList.Controls.Add(ProductGb);
                i++;
            }
        }

        private void RemoveCartBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (Button)sender;
            string[] product_id = btn.Name.Split('_');
            int _productid = Convert.ToInt32(product_id[product_id.Length - 1]);

            sellProductCrud.Delete(_productid);

            MessageBox.Show("Ürün Sepetiniden Silindi", "Sepet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CartList.Controls.Clear();
            ProductListingIntoPanel();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }

        private void CustomerCartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }

        private void BuyCartBtn_Click(object sender, EventArgs e)
        {
            _order.IsStatus = true;
            orderCrud.Update(_order, _order.Id);
            CartList.Controls.Clear();
            ProductListingIntoPanel();
            MessageBox.Show("Ürünler Satın Alındı", "Sepet", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CustomerCartForm_SizeChanged(object sender, EventArgs e)
        {
            TitleCenter();
        }
    }
}
