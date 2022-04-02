using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Models.Models
{
    public class MediaCrewMember
    {
        public int Id { get; set; }
        [Required]
        public int CrewMemberId { get; set; }
        [ForeignKey("CrewMemberId")]
        public CrewMember CrewMember { get; set; }
        [Required]
        public int MediaId { get; set; }
        [ForeignKey("MediaId")]
        public Media Media { get; set; }
        [Required]
        public string Role { get; set; }

    }
}
