using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GuiFlix_DTOs.DTOs
{
    public class MediaDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public PegiTypes Pegi { get; set; }
        public DateTime RealeaseDate { get; set; }
        public string Description { get; set; }
        public string ThumbnailLink { get; set; }
        [JsonIgnore]
        public ICollection<ListDTO> Lists { get; set; }
        public ICollection<CategoryDTO> Categories { get; set; }
        public ICollection<MediaCrewMemberDTO> CrewMembers { get; set; }

        public enum PegiTypes
        {
            ALL,
            Pegi7,
            Pegi13,
            Pegi16,
            Pegi18
        }
    }
}
