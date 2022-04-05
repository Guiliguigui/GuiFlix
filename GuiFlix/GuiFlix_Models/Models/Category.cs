using System.Collections.Generic;

namespace GuiFlix_Models.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Media> Medias { get; set; }
    }
}
