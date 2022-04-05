using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
