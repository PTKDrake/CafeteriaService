using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeteriaService.Models
{
    [Table("Orders")]
    public class Order: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalPrice => (from orderDetails in OrderLines select orderDetails.Price).Sum();

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalPaid { get; set; }

        [DefaultValue(0)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Change => TotalPaid - TotalPrice;

        public ICollection<OrderDetail> OrderLines { get; set; } = new List<OrderDetail>();

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
