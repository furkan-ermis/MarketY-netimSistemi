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
    public partial class AdminForm : Form
    {
        static bool isUserList=false;
        ProductCrud productCrud = new ProductCrud();
        UserCrud userCrud = new UserCrud();
        RoleCrud roleCrud = new RoleCrud();
        CategoryCrud categoryCrud = new CategoryCrud();
        GroupBox ItemGb=new GroupBox();
        PictureBox ItemImgPb =new PictureBox();
        Label ItemNameLabel = new Label();
        Label ItemPriceLbl = new Label();
        Label ItemStockLbl = new Label();
        Button ItemUpdateBtn = new Button();
        Button ItemDeleteBtn = new Button();
        Button UserUpdateBtn = new Button();
        Button UserDeleteBtn = new Button();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            AdminNameLbl.Text = LoginForm.CurrentUser.Name;
            ProductList();
        }
        private void ProductList()
        {
            isUserList = false;
            int xStart = 20;
                int yStart = 20;
                int i = 0;
                int step = 170;
                int productGbCountPerRow = ((ListPanel.Width - xStart) - (ListPanel.Width - xStart) % step) / step;
                var Items = productCrud.GetAll();
                foreach (var item in Items)
                {
                    if (productGbCountPerRow == i)
                    {
                        yStart += step + 130;
                        i = 0;
                    }
                ItemGb = new GroupBox()
                {
                    Name = "ProductGb_" + item.Id,
                    Text = categoryCrud.GetById(item.CategoryId).Name,
                        Size = new Size(150, 280),
                        BackColor = Color.White,
                        Location = new Point(xStart + (step * i), yStart)
                    };
                ItemImgPb = new PictureBox()
                    {
                        Name = "ProductImgPb_" + item.Id,
                        ImageLocation = item.Image,
                        Size = new Size(120, 140),
                        Location = new Point(15, 15),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                ItemNameLabel = new Label()
                    {
                        Name = "ProductName_" + item.Id,
                        Text = item.Name.ToString(),
                        Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
                        Size = new Size(120, 40),
                        Location = new Point(15, 165)
                    };
                ItemPriceLbl = new Label()
                {
                    Name = "ProductPrice_" + item.Id,
                    Text = "Fiyat: " + item.Price,
                    Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(120, 40),
                    Location = new Point(15, 150)
                };
                ItemStockLbl = new Label()
                {
                    Name = "ProductStock_" + item.Id,
                    Text = "Stok: " + item.Stock,
                    Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(120, 40),
                    Location = new Point(15, 135)
                };
                ItemUpdateBtn = new System.Windows.Forms.Button()
                    {
                        Name = "ProductUpdateBtn_" + item.Id,
                        Text = "Düzenle",
                        Location = new Point(15, 195),
                        Size = new Size(120, 30),
                        FlatStyle = FlatStyle.Popup,
                        BackColor = Color.Green,
                        ForeColor = Color.White,
                        Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                    };
                ItemDeleteBtn = new System.Windows.Forms.Button()
                    {
                        Name = "ProductDelete_" + item.Id,
                        Text = "Sil",
                        Location = new Point(15, 235),
                        Size = new Size(120, 30),
                        FlatStyle = FlatStyle.Popup,
                        BackColor = Color.Red,
                        ForeColor = Color.White,
                        Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                    };
                ItemUpdateBtn.Click += ItemUpdateBtn_Click; ;
                ItemDeleteBtn.Click += ItemDeleteBtn_Click; ;
                    ItemGb.Controls.Add(ItemUpdateBtn);
                    ItemGb.Controls.Add(ItemDeleteBtn);
                    ItemGb.Controls.Add(ItemNameLabel);
                    ItemGb.Controls.Add(ItemPriceLbl);
                    ItemGb.Controls.Add(ItemStockLbl);
                    ItemGb.Controls.Add(ItemImgPb);
                    ListPanel.Controls.Add(ItemGb);
                    i++;
            }
        }
        private void UserList()
        {
            isUserList = true;
            int xStart = 20;
            int yStart = 20;
            int i = 0;
            int step = 170;
            int userGbCountPerRow = ((ListPanel.Width - xStart) - (ListPanel.Width - xStart) % step) / step;
            var Items = userCrud.GetAll();
            foreach (var item in Items)
            {
                if (userGbCountPerRow == i)
                {
                    yStart += step + 130;
                    i = 0;
                }
                ItemGb = new GroupBox()
                {
                    Name = "UserGb_" + item.Id,
                    Text = roleCrud.GetById(item.RoleId).Name,
                    Size = new Size(150, 300),
                    BackColor = Color.White,
                    Location = new Point(xStart + (step * i), yStart)
                };
                ItemImgPb = new PictureBox()
                {
                    Name = "UserImgPb_" + item.Id,
                    ImageLocation = item.Image,
                    Size = new Size(120, 140),
                    Location = new Point(15, 15),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                ItemNameLabel = new Label()
                {
                    Name = "UserName_" + item.Id,
                    Text = item.Name+" "+item.Surname,
                    Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(120, 20),
                    Location = new Point(15, 155)
                };
                ItemPriceLbl = new Label()
                {
                    Name = "userEmail_" + item.Id,
                    Text = "Email: " + item.Email,
                    Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(120, 30),
                    Location = new Point(15, 180)
                };
                ItemStockLbl = new Label()
                {
                    Name = "userStock_" + item.Id,
                    Text = "Parola: " + item.Password,
                    Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(120, 20),
                    Location = new Point(15, 215)
                };
                UserUpdateBtn = new System.Windows.Forms.Button()
                {
                    Name = "userUpdateBtn_" + item.Id,
                    Text = "Düzenle",
                    Location = new Point(15, 235),
                    Size = new Size(120, 30),
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                };
                UserDeleteBtn = new System.Windows.Forms.Button()
                {
                    Name = "userDelete_" + item.Id,
                    Text = "Sil",
                    Location = new Point(15, 268),
                    Size = new Size(120, 30),
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162))),
                };
                UserUpdateBtn.Click += UserUpdateBtn_Click;
                UserDeleteBtn.Click += UserDeleteBtn_Click;
                ItemGb.Controls.Add(UserUpdateBtn);
                ItemGb.Controls.Add(UserDeleteBtn);
                ItemGb.Controls.Add(ItemNameLabel);
                ItemGb.Controls.Add(ItemPriceLbl);
                ItemGb.Controls.Add(ItemStockLbl);
                ItemGb.Controls.Add(ItemImgPb);
                ListPanel.Controls.Add(ItemGb);
                i++;
            }
        }
        private void UserDeleteBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] user_id = btn.Name.Split('_');
            int _userId = Convert.ToInt32(user_id[user_id.Length - 1]);
            userCrud.Delete(_userId);
            MessageBox.Show("Ürün Silindi", "Sepet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListPanel.Controls.Clear();
            UserList();
        }
        private void UserUpdateBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] user_id = btn.Name.Split('_');
            int _userId = Convert.ToInt32(user_id[user_id.Length - 1]);
            User user = userCrud.GetById(_userId);
            UpdateUserForm updateUserForm = new UpdateUserForm(user);
            updateUserForm.Show();
            this.Hide();
        }
        private void ItemDeleteBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] product_id = btn.Name.Split('_');
            int _productId = Convert.ToInt32(product_id[product_id.Length - 1]);
            productCrud.Delete(_productId);
            MessageBox.Show("Ürün Sepetinize Eklendi", "Sepet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListPanel.Controls.Clear();
            ProductList();

        }
        private void ItemUpdateBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] product_id = btn.Name.Split('_');
            int _productId = Convert.ToInt32(product_id[product_id.Length - 1]);
            Product product =productCrud.GetById(_productId);
            UpdateProduct updateProduct = new UpdateProduct(product);
            updateProduct.Show();
            this.Hide();
        }
        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            ListPanel.Controls.Clear();
            ProductList();
        }
        private void UsersBtn_Click(object sender, EventArgs e)
        {
            ListPanel.Controls.Clear();
            UserList();
        }
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Dispose();
        }
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
            this.Hide();
        }
        private void AdminForm_SizeChanged(object sender, EventArgs e)
        {
            ListPanel.Controls.Clear();
            if (isUserList )
            {
                UserList();
            }
            else
            {
            ProductList();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }

        private void RaportsBtn_Click(object sender, EventArgs e)
        {
            RaportsForm raportsForm = new RaportsForm();
            raportsForm.Show();
            this.Hide();
        }
    }

}
