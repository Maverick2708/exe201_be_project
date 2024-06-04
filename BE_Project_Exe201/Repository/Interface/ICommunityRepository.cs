using Repository.Models;
using Repository.ViewModels.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface ICommunityRepository
    {
        public Task<ResponeModel.ResponeModel> CreateCommunity(CreateCommunityModel createCommunity);
        public Task<IEnumerable<Community>> GetAllCommunity();
       
        public Task<IEnumerable<Community>> GetCommunityByName(string name);

    }
}
