using System.ComponentModel.DataAnnotations;

namespace BigProje.Models.DTOs
{
    public class LoginDTO
    {
        [Required]
        [MinLength(4, ErrorMessage = "Email Alani en az 5 karakter olmaildir")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string RememberMe { get; set; }
    }
}
