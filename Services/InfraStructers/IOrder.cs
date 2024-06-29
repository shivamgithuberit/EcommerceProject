using EcommerceProject.Models;

namespace EcommerceProject.Services.InfraStructers
{
    public interface IOrder
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);

        void Insert(Order order);

        void Update(Order order);

        void Delete(int id);

        int Count();

        void Save();
    }
}
