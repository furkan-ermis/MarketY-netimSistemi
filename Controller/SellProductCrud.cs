using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Controller
{
    public class SellProductCrud
    {
        DataContext _context = new DataContext();
        public bool Add(SellProduct entity)
        {
            if (entity != null)
            {
                _context.SellProduct.Add(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            SellProduct SellingProduct = _context.SellProduct.Find(id);
            if (SellingProduct != null && !SellingProduct.IsDelete)
            {
                SellingProduct.IsDelete = true;
                _context.SellProduct.Remove(SellingProduct);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<SellProduct> GetAll(int orderId)
        {
            return _context.SellProduct.Where(x=>x.IsDelete==false && x.OrderId== orderId).ToList();


        }
        public SellProduct GetById(int id)
        {
            SellProduct SellingProduct = _context.SellProduct.Find(id);
            if (SellingProduct != null)
            {
                return SellingProduct;
            }
            return null;
        }

        public bool Update(SellProduct entity, int id)
        {
            SellProduct SellingProduct = _context.SellProduct.Find(id);
            if (SellingProduct != null && !SellingProduct.IsDelete)
            {
                SellingProduct = entity;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
