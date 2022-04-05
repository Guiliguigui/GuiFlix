using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
