using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GuiFlix_DTOs.DTOs
{
    public class ListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProfileId { get; set; }
        [JsonIgnore]
        public virtual ProfileDTO Profile { get; set; }
        public ICollection<MediaDTO> Medias { get; set; }
    }
}
