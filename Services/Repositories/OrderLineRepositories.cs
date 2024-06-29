using EcommerceProject.Data;
using EcommerceProject.Models;
using EcommerceProject.Services.InfraStructers;

namespace EcommerceProject.Services.Repositories
{
    public class OrderLineRepositories : IOrderLine
    {
        private EcommerceDbContext _context;

        public OrderLineRepositories(EcommerceDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.Orders.Count();
        }

        public void Delete(int id)
        {
            var order = _context.OrderLines.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                _context.OrderLines.Remove(order);
            }
        }

        public OrderLine GetOrderLine(int id)
        {
            var order = _context.OrderLines.FirstOrDefault(o => o.Id == id);
            if(order != null)
            {
                return order;
            }
            return null;
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
           return _context.OrderLines;
        }

        public void Insert(OrderLine orderLine)
        {
            _context.OrderLines.Add(orderLine);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(OrderLine orderLine)
        {
            _context.Update(orderLine);
        }
    }
}
