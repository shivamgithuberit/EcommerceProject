using EcommerceProject.Data;
using EcommerceProject.Models;
using EcommerceProject.Services.InfraStructers;

namespace EcommerceProject.Services.Repositories
{
    public class ProductRepositories : IProduct
    {
        private EcommerceDbContext _context;

        public ProductRepositories(EcommerceDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.Products.Count();
        }

        public void Delete(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
        }

        public Product GetProduct(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);
            if (product != null)
            {
                return product;
            }
            return null;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        public void Insert(Product product)
        {
            _context.Products.Add(product);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Update(product);
        }
    }
}
