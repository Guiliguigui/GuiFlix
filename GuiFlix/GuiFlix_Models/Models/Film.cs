using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
