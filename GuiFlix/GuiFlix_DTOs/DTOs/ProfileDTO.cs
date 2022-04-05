using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GuiFlix_DTOs.DTOs
{
    public class ProfileDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string AvatarLink { get; set; }
        public int AccountId { get; set; }
        [JsonIgnore]
        public AccountDTO Account { get; set; }
        [JsonIgnore]
        public ICollection<ListDTO> Lists { get; set; }
        [JsonIgnore]
        public ICollection<LikeDTO> Likes { get; set; }
    }
}
