using System.ComponentModel.DataAnnotations;

namespace GuiFlix_API.DTOs.Authentication
{
    public class LoginRequestUserDTO
    {
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
