using MarketYönetimSistemi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity.Interface
{
    public class ProductCrud : ICrud<Product>
    {
        DataContext _context = new DataContext();

        public bool Add(Product entity)
        {
            if (entity != null)
            {
                _context.Product.Add(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Product currentProduct = _context.Product.Find(id);
            if (currentProduct != null && !currentProduct.IsDelete)
            {
                currentProduct.IsDelete = true;
                _context.Product.Remove(currentProduct);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Product> GetAll()
        {
            return _context.Product.Where(x=>x.IsDelete==false).ToList();
        }

        public Product GetById(int id)
        {
            Product currentProduct = _context.Product.Find(id);
            if (currentProduct != null)
            {
                return currentProduct;
            }
            return null;
        }

        public bool Update(Product entity, int id)
        {
            Product currentProduct = _context.Product.Find(id);
            if (currentProduct != null && !currentProduct.IsDelete)
            {
                currentProduct.CategoryId = entity.CategoryId;
                currentProduct.Description = entity.Description;
                currentProduct.Price = entity.Price;
                currentProduct.IsStatus = entity.IsStatus;
                currentProduct.Image = entity.Image;
                currentProduct.Name= entity.Name;
                currentProduct.IsDelete= entity.IsDelete;
                currentProduct.Stock = entity.Stock;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
