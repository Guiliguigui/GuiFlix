using GuiFlix_API.Validators;
using System.ComponentModel.DataAnnotations;

namespace GuiFlix_API.DTOs.Authentication
{
    public class RegisterRequestUserDTO
    {
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[a-zA-Z0-9_.$!%-]+@[a-zA-Z0-9.-]+.[a-zA-Z]+$", ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid phone number")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "FirstName is required")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        public string? LastName { get; set; }
        [PasswordValidator]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
