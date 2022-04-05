using System.Collections.Generic;

namespace GuiFlix_DTOs.DTOs
{
    public class CrewMemberDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<MediaCrewMemberDTO> Medias { get; set; }
    }
}
