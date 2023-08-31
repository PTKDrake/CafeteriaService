using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CafeteriaService.Models
{
    [Table("Users")]
    [Index(nameof(Username), IsUnique = true)]
    public class User: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(500)]
        public string Password { get; set; }

        public virtual Role Role { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
    }
}