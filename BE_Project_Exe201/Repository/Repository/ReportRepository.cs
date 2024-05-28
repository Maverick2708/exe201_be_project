using Repository.Interface;
using Repository.Models;
using Repository.ViewModels.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly HabestContext _context;

        public ReportRepository(HabestContext context)
        {
            _context = context;
        }

        public async Task<ResponeModel.ResponeModel> CreateReport(CreateReportModel addReportModel)
        {
            try
            {
                var report = new Report
                {
                    IdPost = addReportModel.IdPost,
                    UserId = addReportModel.UserId,
                    Description = addReportModel.Description,
                    Status = true
                };
                _context.Reports.Add(report);
                await _context.SaveChangesAsync();

                return new ResponeModel.ResponeModel { Status = "Success", Message = "Added report successfully", DataObject = report };

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return new ResponeModel.ResponeModel { Status = "Error", Message = "An error occurred while adding the report" };
            }
        }
    }
}
