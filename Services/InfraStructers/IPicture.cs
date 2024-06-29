using EcommerceProject.Models;

namespace EcommerceProject.Services.InfraStructers
{
    public interface IPicture
    {
        
        Picture GetPicture(int id);

        void Insert(Picture picture);

        void Update(Picture picture);

        void Delete(int id);

        int Count();

        void Save();
    }
}
