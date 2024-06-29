using EcommerceProject.Data;
using EcommerceProject.Models;
using EcommerceProject.Services.InfraStructers;

namespace EcommerceProject.Services.Repositories
{
    public class CartItemRepositories : ICartItem
    {

        private EcommerceDbContext _context;

        public CartItemRepositories(EcommerceDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.CartItems.Count();
        }

        public void Delete(int id)
        {
            var cartitem = _context.CartItems.FirstOrDefault(c => c.Id == id);
            if (cartitem != null)
            {
                _context.CartItems.Remove(cartitem);
            }
        }

        public CartItem GetCartItem(int id)
        {
            var Cartitem = _context.CartItems.FirstOrDefault(c => c.Id == id);
            if (Cartitem != null)
            {
                return Cartitem;
            }
            return null;
        }

        public IEnumerable<CartItem> GetCartItems()
        {
            return _context.CartItems;
        }

        public void Insert(CartItem cartItem)
        {
            _context.CartItems.Add(cartItem);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(CartItem cartItem)
        {
            _context.Update(cartItem);
        }
    }
}
