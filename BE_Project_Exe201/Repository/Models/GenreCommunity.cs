using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public partial class GenreCommunity
    {
        public GenreCommunity() 
        {
            Communities = new HashSet<Community>();
        }
        public int IdGenre { get; set; }
        public string? GenreName { get; set; }

        public virtual ICollection<Community> Communities { get; set; }
    }
}
