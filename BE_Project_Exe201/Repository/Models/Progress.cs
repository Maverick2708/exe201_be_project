using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public partial class Progress
    {
        public Progress() 
        {
            Tasks = new HashSet<Task>();
        }

        public int IdProgress { get; set; }
        public string? ProgressName { get; set; }
        public int Precent { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
