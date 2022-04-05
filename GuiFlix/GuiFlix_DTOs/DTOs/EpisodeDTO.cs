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
    public class EpisodeDTO
    {
        public int Id { get; set; }
        public string Season { get; set; }
        public int EpisodeNumber { get; set; }
        public string Name { get; set; }
        public DateTime RealeaseDate { get; set; }
        public string Description { get; set; }
        public string ThumbnailLink { get; set; }
        public int TVShowId { get; set; }
        [JsonIgnore]
        public TVShowDTO TVShow { get; set; }
        public TimeSpan Duration { get; set; }
        public string SourceLink { get; set; }
    }
}
