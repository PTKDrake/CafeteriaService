using CafeteriaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaService.Controllers
{
    public class OrderDetailController
    {
        private readonly CafeteriaDbContext _context;

        public OrderDetailController(CafeteriaDbContext context)
        {
            _context = context;
        }

        public OrderDetail CreateOrderDetail(Order order, Item item, int amount)
        {
            OrderDetail orderDetail = new OrderDetail
            {
                Order = order,
                Item = item,
                Amount = amount
            };
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
            return orderDetail;
        }

        public List<OrderDetail> FilterByItem(Item item)
        {
            return (from order in _context.OrderDetails where order.Item.Equals(item) select order).ToList();
        }
    }
}
