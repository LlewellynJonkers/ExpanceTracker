using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Expance_Tracker.Models
{
    [PrimaryKey(nameof(Id))]
    public class ExpenceItem
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string CategoryID { get; set; }
    }
}
