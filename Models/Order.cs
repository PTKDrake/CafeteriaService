using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeteriaService.Models
{
    [Table("Orders")]
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Required]
        [Timestamp]
        public byte[] PlacedTime { get; set; }

        [Required]
        public decimal TotalPrice
        {
            get
            {
                return (from orderDetails in OrderLines select orderDetails.Price).Sum();
            }
        }

        [Required]
        public decimal TotalPaid { get; set; }

        [DefaultValue(0)]
        public decimal Change
        {
            get
            {
                return TotalPaid - TotalPrice;
            }
        }

        public virtual ICollection<OrderDetail> OrderLines { get; set; } = new List<OrderDetail>();

        public ICollection<OrderDetail> AddOrderDetail(OrderDetail[] orderDetails)
        {
            foreach (OrderDetail orderDetail in orderDetails)
            {
                OrderLines.Add(orderDetail);
            }

            return OrderLines;
        }

        public ICollection<OrderDetail> AddOrderDetail(OrderDetail orderDetail)
        {
            OrderLines.Add(orderDetail);
            return OrderLines;
        }
    }
}
