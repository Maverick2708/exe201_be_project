using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public partial class Task
    {
        public Task() 
        {
           Posts = new HashSet<Post>();
        }
        public int IdTask { get; set; }
        public string? UserId { get; set; }
        public int IdCommunity { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }
        public int IsVerified { get; set;}
        public DateTime? DateCompleted { get; set; }
        public int IdProgress { get; set; }
        public int Point {  get; set; }
        public bool? Status { get; set; }

        public virtual Progress? Progress { get; set; }
        public virtual Person? User { get; set; }
        public virtual Community? Community { get; set; }

        public virtual ICollection<Post> Posts { get; set;}

    }
}
