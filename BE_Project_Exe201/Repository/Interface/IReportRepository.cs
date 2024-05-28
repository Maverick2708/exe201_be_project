using Repository.ViewModels.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IReportRepository
    {
        public Task<ResponeModel.ResponeModel> CreateReport(CreateReportModel addReportModel);

    }
}
