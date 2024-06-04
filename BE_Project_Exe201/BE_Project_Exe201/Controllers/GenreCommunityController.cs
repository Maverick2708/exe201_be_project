using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using Repository.ViewModels.Community;
using Repository.ViewModels.Report;
using Services.Interface;
using Services.Services;

namespace BE_Project_Exe201.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreCommunityController : ControllerBase
    {
        private readonly IGenreCommunityService _genreCommunityService;

        public GenreCommunityController(IGenreCommunityService personService)
        {
            _genreCommunityService = personService;
        }
        [HttpPost("CreateGenreCommunity")]
        public async Task<IActionResult> CreateGenre(GenreCommunityModel createGenreModel)
        {
            var response = await _genreCommunityService.CreateGenreCommunity(createGenreModel);
            if (response.Status == "Error")
            {
                return Conflict(response);
            }
            return Ok(response);
        }

    }
}
