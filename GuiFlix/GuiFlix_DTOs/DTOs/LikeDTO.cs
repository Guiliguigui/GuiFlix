using System.Text.Json.Serialization;

namespace GuiFlix_DTOs.DTOs
{
    public class LikeDTO
    {
        public int Id { get; set; }
        public LikeTypes Type { get; set; }
        public int ProfileId { get; set; }
        [JsonIgnore]
        public ProfileDTO Profile { get; set; }
        public enum LikeTypes
        {
            Love,
            Like,
            Dislike
        }
    }
}
