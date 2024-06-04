using Firebase.Storage;
using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using Repository.Models;
using Repository.ViewModels.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Repository.Repository
{
    public class CommunityRepository : ICommunityRepository
    {
        private readonly HabestContext _context;

        public CommunityRepository(HabestContext context)
        {
            _context = context;
        }
        public async Task<ResponeModel.ResponeModel> CreateCommunity(CreateCommunityModel createCommunity)
        {

            try
            {
                var community = new Community
                {
                    CommunityName = createCommunity.CommunityName,
                    MemberCount = createCommunity.MemberCount,
                    AvatarCommunity = createCommunity.AvatarCommunity,
                    BackgroundCommunity = createCommunity.BackgroundCommunity,
                    IdGenre = createCommunity.IdGenre,
                    Status = true,

                };
                _context.Communities.Add(community);
                await _context.SaveChangesAsync();

                return new ResponeModel.ResponeModel { Status = "Success", Message = "Added new community successfully", DataObject = createCommunity };

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return new ResponeModel.ResponeModel { Status = "Error", Message = "An error occurred while adding new community" };
            }
            
        }


        public async Task<IEnumerable<Community>> GetAllCommunity()
        {
            return await _context.Communities.OrderByDescending(o => o.MemberCount).ToListAsync();
        }


        public async Task<IEnumerable<Community>> GetCommunityByName(string name)
        {
            var communities = await _context.Communities
                 .Where(c => c.CommunityName.Trim().ToLower().IndexOf(name.Trim().ToLower()) != -1)
                 .Select(u => u.CommunityName).FirstOrDefaultAsync();

            var commnunitiesByName = await _context.Communities
                       .Where(c => c.CommunityName == communities).ToListAsync();
            return commnunitiesByName;
        }

       
    }
}
