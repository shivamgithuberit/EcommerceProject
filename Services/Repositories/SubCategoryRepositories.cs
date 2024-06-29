using EcommerceProject.Data;
using EcommerceProject.Models;
using EcommerceProject.Services.InfraStructers;

namespace EcommerceProject.Services.Repositories
{
    public class SubCategoryRepositories : ISubCategory
    {
        private EcommerceDbContext _context;

        public SubCategoryRepositories(EcommerceDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.SubCategories.Count();
        }

        public void Delete(int id)
        {
            var subcategory=_context.SubCategories.FirstOrDefault(c => c.Id == id);
            if (subcategory != null)
            {
                _context.SubCategories.Remove(subcategory);
            }
        }

        public IEnumerable<SubCategory> GetSubCategories()
        {
            return _context.SubCategories;
        }

        public SubCategory GetSubCategory(int id)
        {
            var subcategory = _context.SubCategories.FirstOrDefault(c => c.Id == id);
            if (subcategory != null)
            {
                return subcategory;
            }
            return null;
        }

        public void Insert(SubCategory subCategory)
        {
            _context.SubCategories.Add(subCategory);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(SubCategory subCategory)
        {
            _context.Update(subCategory);
        }
    }
}
