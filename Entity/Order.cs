using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity
{
    // Order, Id, UserId,OrderDateTine,İsDelete
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDateTime { get; set; }=DateTime.Now;
        public bool IsDelete { get; set; }
        public bool IsStatus { get; set; } = true;
        public List<SellProduct> SellProductList { get; set; }
    }
}
