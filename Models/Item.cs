using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeteriaService.Models
{
    [Table("Items")]
    public class Item: BaseEntity
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
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [Required]
        public string? ImagePath { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}