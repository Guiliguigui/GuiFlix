using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Models.Models
{
    public class Like
    {
        public int Id { get; set; }
        public LikeTypes Type { get; set; }
        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public Profile Profile { get; set; }
        public enum LikeTypes
        {
            Love,
            Like,
            Dislike
        }
    }
}
