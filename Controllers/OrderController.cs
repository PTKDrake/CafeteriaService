using CafeteriaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaService.Controllers
{
    public class OrderController
    {
        private readonly CafeteriaDbContext _context;

        public OrderController(CafeteriaDbContext context)
        {
            _context = context;
        }

        public Order CreateOrder(decimal totalPaid, List<OrderDetail>? orderLines = null)
        {
            decimal totalPrice = orderLines != null ? (from orderDetails in orderLines select orderDetails.Price).Sum() : 0;
            Order order = new Order
            {
                TotalPaid = totalPaid,
                OrderLines = orderLines ?? new List<OrderDetail>()
            };
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }
    }
}
