using GuiFlix_Models.Models;

namespace GuiFlix_API.DTOs.Authentication
{
    public class LoginResponseAdminDTO
    {
        public bool IsAuthSuccessful { get; set; }
        public string? ErrorMessage { get; set; }
        public string? Token { get; set; }
    }
}
