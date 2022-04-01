using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Models.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string AvatarLink { get; set; }
        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        public ICollection<List> Lists { get; set; }
        public ICollection<Like> Likes { get; set; }
    }
}
