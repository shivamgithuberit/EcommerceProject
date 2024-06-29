using EcommerceProject.Models;

namespace EcommerceProject.Services.InfraStructers
{
    public interface ISubCategory
    {
        IEnumerable<SubCategory> GetSubCategories();
        SubCategory GetSubCategory(int id);

        void Insert(SubCategory subCategory);

        void Update(SubCategory subCategory);

        void Delete(int id);

        int Count();

        void Save();
    }
}
