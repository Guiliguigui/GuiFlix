using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GuiFlix_Models.Models
{
    public class Profile
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string AvatarLink { get; set; }
        [Required]
        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        public ICollection<List> Lists { get; set; }
        public ICollection<Like> Likes { get; set; }
    }
}
