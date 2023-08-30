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

        public Order CreateOrder(decimal totalPaid, List<OrderDetail> orderLines)
        {
            decimal totalPrice = (from orderDetails in orderLines select orderDetails.Price).Sum();
            Order order = new Order
            {
                TotalPaid = totalPaid,
                OrderLines = orderLines
            };
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }
    }
}
