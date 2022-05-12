namespace GuiFlix_API.Services
{
    public interface ICryptPasswordService
    {
        public string EncryptPassword(string? password);
        public string DecryptPassword(string? cryptedString);
    }
}
