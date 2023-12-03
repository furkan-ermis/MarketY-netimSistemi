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
    public partial class RaportsForm : Form
    {
        OrderCrud orderCrud=new OrderCrud();
        public RaportsForm()
        {
            InitializeComponent();
        }

        private void GetDataBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            List<Order> orders = OrdersByDate(startDate, endDate);

            GetOrders(orders);
        }

        private List<Order> OrdersByDate(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = orderCrud.GetAll().Where(o => o.OrderDateTime >= startDate && o.OrderDateTime <= endDate).ToList();

            return orders;
        }

        private void GetOrders(List<Order> orders)
        {
            panel1.Controls.Clear();
            int yStart = 20; 
            foreach (var order in orders)
            {
                Label orderLabel = new Label
                {
                    Text = $"Order ID: {order.Id}, User ID: {order.UserId}, Date: {order.OrderDateTime}, Status: {(order.IsStatus ? "Active" : "Passive")}",
                    Location = new Point(20, yStart),
                    AutoSize = true
                };
                panel1.Controls.Add(orderLabel);
                yStart += 30;
            }
        }

        private void RaportsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
    }
}
