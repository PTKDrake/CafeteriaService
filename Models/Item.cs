using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeteriaService.Models
{
    [Table("Items")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = "";

        [StringLength(200)]
        public string? Description { get; set; }

        [Required] 
        public int InStock { get; set; } = 0;

        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<Image>? Images { get; set; }
    }
}