using System;
using System.Text.Json.Serialization;

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
