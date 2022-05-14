using System.ComponentModel.DataAnnotations;

namespace GuiFlix_API.DTOs.Authentication
{
    public class LoginRequestAdminDTO
    {
        [Required(ErrorMessage = "UserName is required")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
