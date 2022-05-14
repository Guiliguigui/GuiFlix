namespace GuiFlix_API.DTOs.Authentication
{
    public class RegisterResponseUserDTO
    {
        public bool IsRegisterationSuccessful { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
