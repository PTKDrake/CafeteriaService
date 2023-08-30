using System.ComponentModel.DataAnnotations.Schema;

namespace CafeteriaService.Models
{
    public class Cart
    {
        private readonly CafeteriaDbContext _context;
        public int Id { get; set; }

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

        public Cart(CafeteriaDbContext context)
        {
            _context = context;
        }

        public CartItem? GetInCart(Item item)
        {
            return _context.CartItems.SingleOrDefault(i => i.Item.Id == item.Id && i.CardId == Id);
        }

        public int AddToCart(Item item, int amount = 1)
        {
            CartItem? cartItem = GetInCart(item);
            int amountLeft = amount;
            if (cartItem == null)
            {
                CartItem newCartItem = new CartItem
                {
                    CardId = Id,
                    Amount = amount,
                    Item = item
                };
                _context.CartItems.Add(newCartItem);
            }
            else
            {
                cartItem.Amount += amount;
                amountLeft = cartItem.Amount;
            }
            item.InStock -= amount;

            _context.SaveChanges();
            return amountLeft;
        }

        public int ReduceFromCart(Item item, int amount = 1)
        {
            CartItem? cartItem = GetInCart(item);
            int amountLeft = 0;
            if (cartItem != null)
            {
                cartItem.Amount -= amount;
                amountLeft = cartItem.Amount;
                if (cartItem.Amount == 0) RemoveFromCart(item);
                item.InStock += amount;
            }

            _context.SaveChanges();
            return amountLeft;
        }

        public void RemoveFromCart(Item item)
        {
            CartItem? cartItem = GetInCart(item);
            if (cartItem != null)
            {
                item.InStock += cartItem.Amount;
                _context.CartItems.Remove(cartItem);
            }

            _context.SaveChanges();
        }

        public void ClearCart()
        {
            CartItems.Clear();
        }
    }
}
