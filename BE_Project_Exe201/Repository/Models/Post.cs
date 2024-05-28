using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public partial class Post
    {
        public Post() 
        {
            Interactions = new HashSet<Interaction>();
            Reports = new HashSet<Report>();
        }

        public int IdPost { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int IdTask { get; set; }
        public DateTime? DatePost { get; set; }

        public virtual Task? Task { get; set; }
        public virtual ICollection<Interaction> Interactions { get; set;}
        public virtual ICollection<Report> Reports { get; set;}
    }
}
