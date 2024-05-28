using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public partial class Reward
    {
        public int id { get; set; }
        public int IdReward { get; set; }
        public string? UserId { get; set; }

        public virtual Person? User { get; set; }
        public virtual RewardDetail? RewardDetail { get; set; }
    }
}
