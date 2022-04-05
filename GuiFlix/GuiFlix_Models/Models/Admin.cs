using System.ComponentModel.DataAnnotations;

namespace GuiFlix_Models.Models
{
    public class Admin
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
