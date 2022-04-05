using System;
using System.ComponentModel.DataAnnotations;

namespace GuiFlix_Models.Models
{
    public class Film : Media
    {
        [Required]
        public TimeSpan Duration { get; set; }
        [Required]
        public string SourceLink { get; set; }
    }
}
