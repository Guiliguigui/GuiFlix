using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GuiFlix_Models.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Phone { get; set; }
        public ICollection<Profile> Profiles { get; set; } 
    }
}
