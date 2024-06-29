using EcommerceProject.Models;

namespace EcommerceProject.Services.InfraStructers
{
    public interface ICategory
    {
        IEnumerable<Category> GetCategeries();
        Category GetCategery(int id);

        void Insert(Category category);

        void Update(Category category);

        void Delete(int id);

        int Count();

        void Save();
    }
}
