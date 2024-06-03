using Repository.Interface;
using Repository.Repository;
using Repository.ResponeModel;
using Repository.ViewModels.Community;
using Repository.ViewModels.Report;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class GenreCommunityService : IGenreCommunityService
    {
        private readonly IGenreCommunityRepository _genreCommunityRepo;

        public GenreCommunityService(IGenreCommunityRepository genreCommunityRepository)
        {
            _genreCommunityRepo = genreCommunityRepository;
        }

        public async Task<ResponeModel> CreateGenreCommunity(GenreCommunityModel createGenreCommunuity)
        {
            return await _genreCommunityRepo.CreateGenreCommunity(createGenreCommunuity);
        }
    }
}
