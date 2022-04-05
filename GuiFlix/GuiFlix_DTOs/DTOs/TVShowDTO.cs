using System.Collections.Generic;

namespace GuiFlix_DTOs.DTOs
{
    public class TVShowDTO : MediaDTO
    {
        public ICollection<EpisodeDTO> Episodes { get; set; }
    }
}
