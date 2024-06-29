using EcommerceProject.Data;
using EcommerceProject.Models;
using EcommerceProject.Services.InfraStructers;

namespace EcommerceProject.Services.Repositories
{
    public class PictureRepositories : IPicture
    {
        private EcommerceDbContext _context;

        public PictureRepositories(EcommerceDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.Pictures.Count();
        }

        public void Delete(int id)
        {
            var picture = _context.Pictures.FirstOrDefault(p => p.Id == id);
            if (picture != null)
            {
                _context.Pictures.Remove(picture);
            }
        }

        public Picture GetPicture(int id)
        {
            var picture = _context.Pictures.FirstOrDefault(p => p.Id == id);
            if(picture != null)
            {
                return picture;
            }
            return null;
        }

        public void Insert(Picture picture)
        {
            _context.Pictures.Add(picture);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Picture picture)
        {
            _context.Update(picture);
        }
    }
}
