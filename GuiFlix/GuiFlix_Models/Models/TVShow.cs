using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiFlix_Models.Models
{
    public class TVShow : Media
    {
        public ICollection<Episode> Episodes { get; set; }
    }
}
