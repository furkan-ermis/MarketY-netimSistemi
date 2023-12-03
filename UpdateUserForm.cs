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
    public partial class UpdateUserForm : Form
    {
        private readonly User _user;
        RoleCrud roleCrud = new RoleCrud();
        UserCrud userCrud = new UserCrud();
        public UpdateUserForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            RoleCb.DataSource = roleCrud.GetAll();
            RoleCb.DisplayMember = "Name";
            RoleCb.ValueMember = "Id";

            NameTxt.Text = _user.Name;
            EmailTxt.Text = _user.Email;
            PasswordTxt.Text = _user.Password;
            SurnameTxt.Text = _user.Surname;
            DescriptionTxt.Text = _user.Description;
            RoleCb.SelectedValue = _user.RoleId;
            IsStatusCb.Checked = _user.IsStatus;
            IsDeleteCb.Checked = _user.IsDelete;
            pictureBox1.ImageLocation = _user.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = NameTxt.Text,
                Surname = SurnameTxt.Text,
                Description = DescriptionTxt.Text,
                Email = EmailTxt.Text,
                Password = PasswordTxt.Text,
                RoleId = Convert.ToInt32(RoleCb.SelectedValue),
                IsStatus = IsStatusCb.Checked,
                IsDelete = IsDeleteCb.Checked,
                Image = pictureBox1.ImageLocation
            };
            userCrud.Update(user,_user.Id);
            DialogResult dialog = MessageBox.Show("Kullanıcı Güncelleme Başarılı", "Kullanıcı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
        }

        private void UpdateUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}
