using System.Text.Json.Serialization;

namespace GuiFlix_DTOs.DTOs
{
    public class MediaCrewMemberDTO
    {
        public int Id { get; set; }
        public int CrewMemberId { get; set; }
        public CrewMemberDTO CrewMember { get; set; }
        public int MediaId { get; set; }
        [JsonIgnore]
        public MediaDTO Media { get; set; }
        public string Role { get; set; }

    }
}
