using EcommerceProject.Data;
using EcommerceProject.Models;
using EcommerceProject.Services.InfraStructers;
using System.Runtime.InteropServices;

namespace EcommerceProject.Services.Repositories
{
    public class CustomerRepositories : ICustomer
    {
        private EcommerceDbContext _context;

        public CustomerRepositories(EcommerceDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.Customers.Count();
        }

        public void Delete(int id)
        {
            var cutomer= _context.Customers.FirstOrDefault(c => c.Id==id);
            if (cutomer!=null)
            {
                _context.Customers.Remove(cutomer); 
            }
        }

        public Customer GetCustomer(int id)
        {
            var customer= _context.Customers.FirstOrDefault(c => c.Id==id);
            if (customer!=null)
            {
                return customer;
            }
            return null;
        }

        public IEnumerable<Customer> GetCustomers()
        {
           return _context.Customers;
        }

        public void Insert(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Update(customer);
        }
    }
}
