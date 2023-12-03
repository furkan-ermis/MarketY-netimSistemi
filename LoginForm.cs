using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Data;
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
    public partial class LoginForm : Form
    {
        UserCrud userCrud = new UserCrud();
        DataContext _context= new DataContext();
        public static User CurrentUser;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            User currentUser=_context.User.FirstOrDefault(x => x.Name == UserNameTxt.Text && x.Password == PasswordTxt.Text);
            if (currentUser != null)
            {
                CurrentUser = currentUser;
                switch (currentUser.RoleId)
                {
                    case 1:
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                        break;
                    case 2:
                        CustomerForm customerForm = new CustomerForm();
                        customerForm.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Hatalı Kullanıcı Adı veya şifre","Giriş Hatası",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                        break;
                }


            }

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
