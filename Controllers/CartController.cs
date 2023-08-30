using CafeteriaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaService.Controllers
{
    public class CartController
    {
        private readonly CafeteriaDbContext _context;

        public CartController(CafeteriaDbContext context)
        {
            _context = context;
        }

        public Cart CreateCart(List<CartItem>? cartItems = null)
        {
            Cart cart = new Cart(_context)
            {
                CartItems = cartItems ?? new List<CartItem>()
            };
            _context.Carts.Add(cart);
            _context.SaveChanges();
            return cart;
        }
    }
}
