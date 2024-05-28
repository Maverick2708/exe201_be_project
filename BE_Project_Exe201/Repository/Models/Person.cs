using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public partial class Person : IdentityUser
    {
        public Person()
        {
            Tasks = new HashSet<Task>();
            Rewards = new HashSet<Reward>();
            Notifications = new HashSet<Notification>();
            Interactions = new HashSet<Interaction>();
            Reports = new HashSet<Report>();
        }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public bool? Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string? Address { get; set; }
        public DateTime? DateUserRe { get; set; }
        public string? Avatar { get; set; }
        public string? BackgroundImg { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public bool? Status { get; set; }
        public bool? IsVerifiedPage { get; set; }
        public bool? IsConfirm { get; set; }
        public int TotalPoint { get; set; }


        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Reward> Rewards { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Interaction> Interactions { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}

