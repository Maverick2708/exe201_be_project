using Repository.Interface;
using Repository.ResponeModel;
using Repository.ViewModels.Report;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ReportServices : IReportServices
    {
        private readonly IReportRepository _reportRepository;

        public ReportServices(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }
        public async Task<ResponeModel> CreateReport(CreateReportModel addReportModel)
        {
            return await _reportRepository.CreateReport(addReportModel);
        }
    }
}
