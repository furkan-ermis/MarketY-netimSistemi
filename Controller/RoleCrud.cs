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
    public class RoleCrud : ICrud<Role>
    {
        DataContext _context = new DataContext();

        public bool Add(Role entity)
        {
            if (entity != null)
            {
                _context.Role.Add(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Role currentRole = _context.Role.Find(id);
            if (currentRole != null && !currentRole.IsDelete)
            {
                currentRole.IsDelete = true;
                _context.Role.Remove(currentRole);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Role> GetAll()
        {
            return _context.Role.Where(x=>x.IsDelete==false).ToList();
        }

        public Role GetById(int id)
        {
            Role currentRole = _context.Role.Find(id);
            if (currentRole != null)
            {
                return currentRole;
            }
            return null;
        }

        public bool Update(Role entity, int id)
        {
            Role currentRole = _context.Role.Find(id);
            if (currentRole != null && !currentRole.IsDelete)
            {
                currentRole = entity;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
