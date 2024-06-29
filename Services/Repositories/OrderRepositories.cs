using EcommerceProject.Data;
using EcommerceProject.Models;
using EcommerceProject.Services.InfraStructers;

namespace EcommerceProject.Services.Repositories
{
    public class OrderRepositories : IOrder
    {
        private EcommerceDbContext _context;

        public OrderRepositories(EcommerceDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.Orders.Count();
        }

        public void Delete(int id)
        {
            var order = _context.Orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                _context.Orders.Remove(order);
            }
        }

        public Order GetOrder(int id)
        {
            var result = _context.Orders.FirstOrDefault(o => o.Id == id);
            if(result != null)
            {
               return result;
            }
            return null;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }

        public void Insert(Order order)
        {
            _context.Orders.Add(order);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Order order)
        {
            _context.Update(order);
        }
    }
}
