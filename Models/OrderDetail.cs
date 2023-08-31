using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaService.Models
{
    [Table("OrderDetails")]
    public class OrderDetail: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Required]
        public int Amount { get; set; }

        public Order Order { get; set; }

        public Item Item { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price
        {
            get
            {
                return Item.Price * Amount;
            }
        }
    }
}
