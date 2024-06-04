using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels.Community
{
    public class CreateCommunityModel
    {
        [MaxLength(100)]
        [Required]
        public string? CommunityName { get; set; }
        public int MemberCount { get; set; }
        public string? AvatarCommunity { get; set; }
        public string? BackgroundCommunity { get; set; }
        public int IdGenre { get; set; }
  
    }
}
