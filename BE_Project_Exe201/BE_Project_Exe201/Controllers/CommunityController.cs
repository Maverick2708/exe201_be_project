using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.ViewModels.Community;
using Services.Interface;
using Services.Services;

namespace BE_Project_Exe201.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunityController : ControllerBase
    {
        private readonly ICommunityService _communityService;

        public CommunityController(ICommunityService communityService)
        {
            _communityService = communityService;
        }
        [HttpGet("GetAllCommunity")]
        public async Task<IActionResult> GettAllCommunity()
        {
            var communities = await _communityService.GetAllCommunity();
            return Ok(communities);
        }
        [HttpPost("CreateCommunity")]
        public async Task<IActionResult> CreateGenre(CreateCommunityModel createCommunityModel)
        {
            var response = await _communityService.CreateCommunity(createCommunityModel);
            if (response.Status == "Error")
            {
                return Conflict(response);
            }
            return Ok(response);
        }
        [HttpGet("GetCommunityByName")]
        public async Task<IActionResult> GetCommunityByName(string name)
        {
            var communities = await _communityService.GetCommunityByName(name);
            return Ok(communities);
        }

    }
}
