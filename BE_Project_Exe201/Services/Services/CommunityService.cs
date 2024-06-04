using Repository.Interface;
using Repository.Models;
using Repository.ResponeModel;
using Repository.ViewModels.Community;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CommunityService : ICommunityService
    {
        private readonly ICommunityRepository _communityRepo;

        public CommunityService(ICommunityRepository communityRepository)
        {
            _communityRepo = communityRepository;
        }

        public async Task<ResponeModel> CreateCommunity(CreateCommunityModel createCommunityModel)
        {
            return await _communityRepo.CreateCommunity(createCommunityModel);
        }

        public async Task<IEnumerable<Community>> GetAllCommunity()
        {
            return await _communityRepo.GetAllCommunity();
        }

        public async Task<IEnumerable<Community>> GetCommunityByName(string name)
        {
            return await _communityRepo.GetCommunityByName(name);
        }
    }
}
