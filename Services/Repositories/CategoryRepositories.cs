using EcommerceProject.Data;
using EcommerceProject.Models;
using EcommerceProject.Services.InfraStructers;
using Microsoft.EntityFrameworkCore;

namespace EcommerceProject.Services.Repositories
{
    public class CategoryRepositories : ICategory
    {

        private EcommerceDbContext _context;

        public CategoryRepositories(EcommerceDbContext context)
        {
            _context = context;
        }
 

        public int Count()
        {
            return _context.Categeries.Count();
        }

        public void Delete(int id)
        {
            var category=_context.Categeries.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _context.Categeries.Remove(category);
            }
        }

        public IEnumerable<Category> GetCategeries()
        {
            return _context.Categeries;
        }

        public Category GetCategery(int id)
        {
            var category= _context.Categeries.FirstOrDefault(c=>c.Id == id);
            if(category != null)
            {
                return category;
            }
            return null;

        }

        public void Insert(Category category)
        {
            _context.Categeries.Add(category);
        }

        public void Save()
        {
            
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Update(category);
        }
    }
}
