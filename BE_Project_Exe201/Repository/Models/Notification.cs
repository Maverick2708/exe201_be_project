﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public partial class Notification
    {
        public int NotificationId { get; set; }
        public string? UserId { get; set; }
        public string? ContentNoti { get; set; }
        public string? UserIdReceive { get; set; }
        public DateTime? DateNoti { get; set; }
        public bool? Status { get; set; }

        public virtual Person? User { get; set; }
    }
}
