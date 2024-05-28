using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public partial class Interaction
    {
        public int IdComment { get; set; }
        public string? ContentComment { get; set; }
        public DateTime? DateComment { get; set; }
        public int IdPost { get; set; }
        public string? UserId { get; set; }
        public bool? IsLikePost { get; set; }
        public bool? Status { get; set; }

        public virtual Person? User { get; set; }
        public virtual Post? Post { get; set; }
    }
}
