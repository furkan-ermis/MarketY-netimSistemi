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
    public class UserCrud : ICrud<User>
    {
        DataContext _context = new DataContext();

        public bool Add(User entity)
        {
            if (entity != null )
            {
                _context.User.Add(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            User currentUser =_context.User.Find(id);
            if (currentUser != null && !currentUser.IsDelete)
            {
                currentUser.IsDelete = true;
                _context.User.Remove(currentUser);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<User> GetAll()
        {
            return _context.User.Where(x=>x.IsDelete==false).ToList();
        }

        public User GetById(int id)
        {
            User currentUser =_context.User.Find(id);
            if (currentUser != null)
            {
                return currentUser;
            }
            return null;
        }

        public bool Update(User entity, int id)
        {
            User currentUser = _context.User.Find(id);
            if (currentUser != null && !currentUser.IsDelete)
            {
                currentUser.Name= entity.Name;
                currentUser.Password= entity.Password;
                currentUser.Email= entity.Email;
                currentUser.Description= entity.Description;
                currentUser.RoleId= entity.RoleId;
                currentUser.Image=entity.Image;
                currentUser.Surname=entity.Surname;
                currentUser.IsDelete = entity.IsDelete;
                currentUser.IsStatus=entity.IsStatus;


                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
