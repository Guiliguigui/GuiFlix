using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Models.Models
{
    public class Video
    {
        public int Id { get; set; }
        [Required]
        public TimeSpan Duration { get; set; }
        [Required]
        public string SourceLink { get; set; }
    }
}
