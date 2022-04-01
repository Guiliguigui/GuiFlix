using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Models.Models
{
    public class List
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public Account Profile { get; set; }
        public ICollection<Media> Medias { get; set; }
    }
}
