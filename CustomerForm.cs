using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketYönetimSistemi
{
    public partial class CustomerForm : Form
    {
        DataContext _context=new DataContext();
        ProductCrud productCrud = new ProductCrud();
        SellProductCrud sellProductCrud = new SellProductCrud();
        OrderCrud orderCrud = new OrderCrud();

        Order CurrentOrder;
        PictureBox ProductImgPb;
        System.Windows.Forms.Button ProductCartBtn;
        System.Windows.Forms.Button ProductDetail;
        Label ProductNameLbl;
        Label ProductPriceLbl;
        GroupBox ProductGb;
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void CustomerForm_SizeChanged(object sender, EventArgs e)
        {
            TitleCenter();
            ProductList.Controls.Clear();
            ProductListingIntoPanel();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
                CurrentOrder = orderCrud.GetById(LoginForm.CurrentUser.Id);
            if (CurrentOrder == null)
            {
                CurrentOrder = new Order() { UserId=LoginForm.CurrentUser.Id,IsDelete=false,IsStatus=false};
                orderCrud.Add(CurrentOrder);
            }
            TitleCenter();
            ProductListingIntoPanel();

        }
        private void ProductCartBtn_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string[] product_id = btn.Name.Split('_');
            int _productid = Convert.ToInt32(product_id[product_id.Length - 1]);

            SellProduct selledProduct = sellProductCrud.GetAll(CurrentOrder.Id).Where(x => x.IsDelete == false).FirstOrDefault(x => x.ProductId == _productid);
            if (selledProduct != null)
            {
                selledProduct.Quantity++;
                sellProductCrud.Update(selledProduct, selledProduct.Id);
            }
            else
            {
                SellProduct sellProduct = new SellProduct();
                Product product = productCrud.GetById(_productid);
                sellProduct.Quantity = 1;
                sellProduct.ProductId = _productid;
                sellProduct.OrderId = CurrentOrder.Id;
                sellProduct.Price = product.Price;
                sellProduct.TotalPrice = sellProduct.Price * sellProduct.Quantity;
                sellProduct.IsDelete = false;
                sellProductCrud.Add(sellProduct);
            }
            

            MessageBox.Show("Ürün Sepetinize Eklendi","Sepet",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            int productGbCountPerRow = ((ProductList.Width - xStart) - (ProductList.Width - xStart) % step) / step;
            foreach (var product in productCrud.GetAll())
            {
                if (productGbCountPerRow == i)
                {
                    yStart += step + 130;
                    i = 0;
                }
                ProductGb = new GroupBox()
                {
                    Name = "ProductGb_" + product.Id,
                    //Text = roleCrud.GetById(product.RoleId).Name,
                    Size = new Size(150, 280),
                    BackColor = Color.White,
                    Location = new Point(xStart + (step * i), yStart)
                };
                ProductImgPb = new PictureBox()
                {
                    Name = "ProductImgPb_" + product.Id,
                    ImageLocation = product.Image,
                    Size = new Size(120, 100),
                    Location = new Point(15, 15),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                ProductNameLbl = new Label()
                {
                    Name = "ProductName_" + product.Id,
                    Text = product.Name.ToString(),
                    Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(120, 40),
                    Location = new Point(15, 155)
                };
                ProductPriceLbl = new Label()
                {
                    Name = "ProductPrice_" + product.Id,
                    Text = "Fiyat: "+product.Price,
                    Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(120, 40),
                    Location = new Point(15, 140)
                };
                ProductCartBtn = new System.Windows.Forms.Button()
                {
                    Name = "ProductCartBtn_" + product.Id,
                    Text = "SEPETE EKLE",
                    Location = new Point(15, 185),
                    Size = new Size(120, 30),
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                };
                ProductDetail = new System.Windows.Forms.Button()
                {
                    Name = "ProductDetail_" + product.Id,
                    Text = "Detaylar",
                    Location = new Point(15, 235),
                    Size = new Size(120, 30),
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                };
                ProductCartBtn.Click += ProductCartBtn_Click;
                ProductDetail.Click += ProductDetail_Click;
                ProductGb.Controls.Add(ProductCartBtn);
                ProductGb.Controls.Add(ProductDetail);
                ProductGb.Controls.Add(ProductNameLbl);
                ProductGb.Controls.Add(ProductPriceLbl);
                ProductGb.Controls.Add(ProductImgPb);
                ProductList.Controls.Add(ProductGb);
                i++;
            }
        }

        private void ProductDetail_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string[] product_id = btn.Name.Split('_');
            int _productId = Convert.ToInt32(product_id[product_id.Length - 1]);
            Product product = productCrud.GetById(_productId);
            ProductDetailForm productDetailForm = new ProductDetailForm(product);
            productDetailForm.ShowDialog();
        }
        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CustomerCartForm customerCartForm = new CustomerCartForm(CurrentOrder);
            customerCartForm.Show();
            this.Hide();
        }
    }
}   
