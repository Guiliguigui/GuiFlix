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
