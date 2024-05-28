using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.ViewModels.Report;
using Services.Interface;

namespace BE_Project_Exe201.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportServices _reportService;

        public ReportController(IReportServices reportService)
        {
            _reportService = reportService;
        }

        [HttpPost("CreateReport")]
        public async Task<IActionResult> CreateReport(CreateReportModel addReportModel)
        {
            var response = await _reportService.CreateReport(addReportModel);
            if (response.Status == "Error")
            {
                return Conflict(response);
            }
            return Ok(response);
        }
    }
}
