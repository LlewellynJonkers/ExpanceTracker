using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Expance_Tracker.Models
{
    [PrimaryKey(nameof(Id))]
    public class ExpenceCategory
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
