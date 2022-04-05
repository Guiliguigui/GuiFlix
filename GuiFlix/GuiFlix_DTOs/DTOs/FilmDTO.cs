using System;

namespace GuiFlix_DTOs.DTOs
{
    public class FilmDTO : MediaDTO
    {
        public TimeSpan Duration { get; set; }
        public string SourceLink { get; set; }
    }
}
