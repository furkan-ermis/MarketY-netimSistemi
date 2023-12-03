using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Controller
{
    public class CategoryCrud : ICrud<Category>
    {
        DataContext _context = new DataContext();

        public bool Add(Category entity)
        {
            if (entity != null )
            {
                _context.Category.Add(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Category currentCategory = _context.Category.Find(id);
            if (currentCategory != null && !currentCategory.IsDelete)
            {
                currentCategory.IsDelete = true;
                _context.Category.Remove(currentCategory);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Category> GetAll()
        {
            return _context.Category.Where(x=>x.IsDelete==false).ToList();
        }

        public Category GetById(int id)
        {
            Category currentCategory = _context.Category.Find(id);
            if (currentCategory != null )
            {
                return currentCategory;
            }
            return null;
        }

        public bool Update(Category entity, int id)
        {
            Category currentCategory = _context.Category.Find(id);
            if (currentCategory != null && !currentCategory.IsDelete)
            {
                currentCategory = entity;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}