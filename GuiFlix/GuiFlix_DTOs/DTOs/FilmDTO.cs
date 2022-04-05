using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_DTOs.DTOs
{
    public class FilmDTO : MediaDTO
    {
        public TimeSpan Duration { get; set; }
        public string SourceLink { get; set; }
    }
}
