using Repository.Models;
using Repository.ResponeModel;
using Repository.ViewModels.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ICommunityService
    {
        public Task<ResponeModel> CreateCommunity(CreateCommunityModel createCommunityModel);

        public Task<IEnumerable<Community>> GetAllCommunity();
        public Task<IEnumerable<Community>> GetCommunityByName(String name);
    }
}
