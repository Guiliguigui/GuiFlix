using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Models.Models
{
    public class Episode
    {
        public int Id { get; set; }
        [Required]
        public string Season { get; set; }
        [Required]
        public int EpisodeNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime RealeaseDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ThumbnailLink { get; set; }
        [Required]
        public int TVShowId { get; set; }
        [ForeignKey("TVShowId")]
        public TVShow TVShow { get; set; }
        [Required]
        public TimeSpan Duration { get; set; }
        [Required]
        public string SourceLink { get; set; }
    }
}
