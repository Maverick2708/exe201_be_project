using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels.Community
{
    public class ListCommunityModel
    {
        public int IdCommunity { get; set; }
        public string? CommunityName { get; set; }
        public int MemberCount { get; set; }
        public string? AvatarCommunity { get; set; }
        public string? BackgroundCommunity { get; set; }
        public int IdGenre { get; set; }
        public bool Status { get; set; }
    }
}
