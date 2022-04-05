using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GuiFlix_Models.Models
{
    public class CrewMember
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public ICollection<MediaCrewMember> Medias { get; set; }
    }
}
