using System.Collections.Generic;

namespace GuiFlix_DTOs.DTOs
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public ICollection<ProfileDTO> Profiles { get; set; } 
    }
}
