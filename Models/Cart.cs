using System.ComponentModel.DataAnnotations.Schema;

namespace CafeteriaService.Models
{
    public class Cart
    {

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

        public CartItem? GetInCart(Item item)
        {
            return CartItems.SingleOrDefault(i => i.Item.Id == item.Id && i.Cart.Equals(this));
        }

        public decimal TotalPrice => (from c in CartItems select c.Amount * c.Item.Price).Sum();

        public void SetCart(Item item, int amount = 1)
        {
            CartItem? cartItem = GetInCart(item);
            if (cartItem == null)
            {
                CartItem newCartItem = new CartItem
                {
                    Cart = this,
                    Amount = amount,
                    Item = item
                };
                CartItems.Add(newCartItem);
            }
            else
            {
                cartItem.Amount = amount;
            }
        }

        public int AddToCart(Item item, int amount = 1)
        {
            CartItem? cartItem = GetInCart(item);
            int amountLeft = amount;
            if (cartItem == null)
            {
                CartItem newCartItem = new CartItem
                {
                    Cart = this,
                    Amount = amount,
                    Item = item
                };
                CartItems.Add(newCartItem);
            }
            else
            {
                cartItem.Amount += amount;
                amountLeft = cartItem.Amount;
            }
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
            }

            return amountLeft;
        }

        public void RemoveFromCart(Item item)
        {
            CartItem? cartItem = GetInCart(item);
            if (cartItem != null)
            {
                CartItems.Remove(cartItem);
            }
        }

        public void ClearCart()
        {
            CartItems.Clear();
        }
    }
}
