using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(25, ErrorMessage = "Your username is too long (25 characters max)")]
        public string Username { get; set; }
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        [Required, Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
