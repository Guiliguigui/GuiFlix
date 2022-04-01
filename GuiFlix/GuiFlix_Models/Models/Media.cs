using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Models.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Pegi { get; set; }
        public DateTime RealeaseDate { get; set; }
        public string Description { get; set; }
        public string ThumbnailLink { get; set; }
        public ICollection<List> Lists { get; set; }
    }
}
