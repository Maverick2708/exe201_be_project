using Repository.ResponeModel;
using Repository.ViewModels.Community;
using Repository.ViewModels.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IGenreCommunityService
    {
        public Task<ResponeModel> CreateGenreCommunity(GenreCommunityModel createGenreCommunuity);
    }
}
