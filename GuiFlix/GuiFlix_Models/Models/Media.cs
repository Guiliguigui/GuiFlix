using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Models.Models
{
    public class Media
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public PegiTypes Pegi { get; set; }
        [Required]
        public DateTime RealeaseDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ThumbnailLink { get; set; }
        public ICollection<List> Lists { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<MediaCrewMember> CrewMembers { get; set; }

        public enum PegiTypes
        {
            ALL,
            Pegi7,
            Pegi13,
            Pegi16,
            Pegi18
        }
    }
}
