using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Controller
{
    public class BuyProductCrud
    {
        DataContext _context = new DataContext();

        public bool Add(BuyProduct entity)
        {
            if (entity != null)
            {
                _context.BuyProduct.Add(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            BuyProduct BuyingProduct = _context.BuyProduct.Find(id);
            if (BuyingProduct != null && !BuyingProduct.IsDelete)
            {
                BuyingProduct.IsDelete = true;
                _context.BuyProduct.Remove(BuyingProduct);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<BuyProduct> GetAll()
        {
            return _context.BuyProduct.Where(x=>x.IsDelete==false).ToList();
        }

        public BuyProduct GetById(int id)
        {
            BuyProduct BuyingProduct = _context.BuyProduct.Find(id);
            if (BuyingProduct != null )
            {
                return BuyingProduct;
            }
            return null;
        }

        public bool Update(BuyProduct entity, int id)
        {
            BuyProduct BuyingProduct = _context.BuyProduct.Find(id);
            if (BuyingProduct != null && !BuyingProduct.IsDelete)
            {
                BuyingProduct = entity;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
