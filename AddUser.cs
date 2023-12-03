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
    public partial class AddUser : Form
    {
        RoleCrud roleCrud = new RoleCrud();
        UserCrud userCrud = new UserCrud();
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            RoleCb.DataSource = roleCrud.GetAll();
            RoleCb.DisplayMember = "Name";
            RoleCb.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            User user= new User()
            {
                Name = NameTxt.Text,
                Surname = SurnameTxt.Text,
                Description = DescriptionTxt.Text,
                Email=EmailTxt.Text,
                Password=PasswordTxt.Text,
                RoleId = Convert.ToInt32(RoleCb.SelectedValue),
                IsStatus = IsStatusCb.Checked,
                IsDelete = IsDeleteCb.Checked,
                Image = pictureBox1.ImageLocation
            };
            userCrud.Add(user);
            DialogResult dialog = MessageBox.Show("Kullanıcı Ekleme Başarılı", "Kullanıcı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
        }
    }
}
