using GuiFlix_API.DTOs;

namespace GuiFlix_API.DTOs.Authentication
{
    public class LoginResponseUserDTO
    {
        public bool IsAuthSuccessful { get; set; }
        public string? ErrorMessage { get; set; }
        public string? Token { get; set; }
    }
}
