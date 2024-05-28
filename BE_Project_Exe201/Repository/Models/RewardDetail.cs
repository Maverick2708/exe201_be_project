using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public partial class RewardDetail
    {
        public RewardDetail() 
        {
            Rewards = new HashSet<Reward>();
        }
        public int IdReward { get; set; }
        public string? Type { get; set; }
        public int Tier { get; set; }
        public int PointTrade { get; set; }

        public virtual ICollection<Reward> Rewards { get; set; }
    }
}
