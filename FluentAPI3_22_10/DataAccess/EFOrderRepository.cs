using FluentAPI3_22_10.Domain.Abstractions;
using FluentAPI3_22_10.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI3_22_10.DataAccess
{
    public class EFOrderRepository : IOrderRepository
    {
        public void AddData(Order data)
        {
            using (var context = new FluentContext())
            {
                context.Orders.Add(data);
               // var errors=context.GetValidationErrors();
                context.SaveChanges();
            }
        }

        public void DeleteData(Order data)
        {
            using (var context = new FluentContext())
            {
                context.Entry(data).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public ICollection<Order> GetAll()
        {
            List<Order> Orders = null;
            using (var context = new FluentContext())
            {
                Orders = context.Orders.ToList();
            }
            return Orders;
        }

        public Order GetData(int id)
        {
            using (var context = new FluentContext())
            {
                var data = context.Orders
                    .Include(o => o.Customer)
                    .FirstOrDefault(c => c.Id == id);
                return data;
            }
        }

        public void UpdateData(Order data)
        {
            using (var context = new FluentContext())
            {
                context.Entry(data).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
