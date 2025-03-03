using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Expance_Tracker.Models
{
    public class RegisterModel
    {
        [Required]
        [MaxLength(30)]
        public required string Firstname { get; set; }

        [Required]
        [MaxLength(30)]
        public required string Lastname { get; set; }

        [Required]
        [MaxLength(60)]
        public required string Username { get; set; }
        [StringLength(10)]
        public string? Telephone { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Email { get; set; }
        [Required]
        [MinLength(8)]
        [PasswordPropertyText]
        public required string Password { get; set; }
        public DateTime? Created { get; set; }
    }
}
