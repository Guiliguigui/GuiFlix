using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GuiFlix_Models.Models
{
    public class Like
    {
        public int Id { get; set; }
        [Required]
        public LikeTypes Type { get; set; }
        [Required]
        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        [JsonIgnore]
        public Profile Profile { get; set; }
        public enum LikeTypes
        {
            Love,
            Like,
            Dislike
        }
    }
}
