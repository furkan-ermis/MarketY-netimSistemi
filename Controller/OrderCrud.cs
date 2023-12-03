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
    public class OrderCrud : ICrud<Order>
    {
        DataContext _context = new DataContext();

        public bool Add(Order entity)
        {
            if (entity != null )
            {
                _context.Order.Add(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Order currentOrder = _context.Order.Find(id);
            if (currentOrder != null && !currentOrder.IsDelete)
            {
                currentOrder.IsDelete = true;
                _context.Order.Remove(currentOrder);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Order> GetAll()
        {
            return _context.Order.Where(x=>x.IsDelete==false).ToList();
        }

        public Order GetById(int Userid)
        {
            Order currentOrder = _context.Order.FirstOrDefault(x=>x.UserId==Userid && x.IsDelete==false && x.IsStatus==false);
            if (currentOrder != null )
            {
                return currentOrder;
            }
            return null;
        }

        public bool Update(Order entity, int id)
        {
            Order currentOrder = _context.Order.Find(id);
            if (currentOrder != null && !currentOrder.IsDelete)
            {
                currentOrder.OrderDateTime = DateTime.Now;
                currentOrder.IsDelete = false;
                currentOrder.UserId = entity.UserId;
                currentOrder.IsStatus=entity.IsStatus;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
