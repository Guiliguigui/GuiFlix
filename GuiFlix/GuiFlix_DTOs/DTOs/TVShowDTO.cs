using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_DTOs.DTOs
{
    public class TVShowDTO : MediaDTO
    {
        public ICollection<EpisodeDTO> Episodes { get; set; }
    }
}
