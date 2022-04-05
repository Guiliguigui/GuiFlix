using System.Collections.Generic;

namespace GuiFlix_DTOs.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MediaDTO> Medias { get; set; }
    }
}
