using System.Collections.Generic;

namespace GuiFlix_Models.Models
{
    public class TVShow : Media
    {
        public ICollection<Episode> Episodes { get; set; }
    }
}
