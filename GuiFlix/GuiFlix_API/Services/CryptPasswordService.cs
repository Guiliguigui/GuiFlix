using System;
using System.Text;

namespace GuiFlix_API.Services
{
    public class CryptPasswordService : ICryptPasswordService
    {
        private readonly string? _securityKey;

        public CryptPasswordService(string? securityKey)
        {
            _securityKey = securityKey;
        }

        public string EncryptPassword(string? password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password + _securityKey));
        }

        public string DecryptPassword(string? cryptedString)
        {
            if (string.IsNullOrEmpty(cryptedString)) return "";
            string decryptedString = Encoding.UTF8.GetString(Convert.FromBase64String(cryptedString));
            return decryptedString.Substring(0, decryptedString.Length - _securityKey!.Length);
        }
    }
}
