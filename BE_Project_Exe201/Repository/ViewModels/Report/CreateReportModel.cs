using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels.Report
{
    public class CreateReportModel
    {
        public int IdPost { get; set; }
        public string? UserId { get; set; }
        public string? Description { get; set; }
    }
}
