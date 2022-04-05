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
    public class ListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProfileId { get; set; }
        [JsonIgnore]
        public virtual ProfileDTO Profile { get; set; }
        public ICollection<MediaDTO> Medias { get; set; }
    }
}
