using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CafeteriaService.Models
{
    [Table("Categories")]
    [Index(nameof(Name), IsUnique = true)]
    public class Category: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = "";

        [StringLength(100)]
        public string? Description { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}