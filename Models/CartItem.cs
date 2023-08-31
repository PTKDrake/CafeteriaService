using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaService.Models
{
    public class CartItem
    {
        public Item Item { get; set; }
        public int Amount { get; set; }
        public Cart Cart { get; set; }
    }
}
