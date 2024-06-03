using Repository.Interface;
using Repository.Models;
using Repository.ViewModels.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class GenreCommunityRepository : IGenreCommunityRepository
    {
        private readonly HabestContext _context;

        public GenreCommunityRepository(HabestContext context)
        {
            _context = context;
        }
       

        public async Task<ResponeModel.ResponeModel> CreateGenreCommunity(GenreCommunityModel createGenreCommunity)
        {
            try
            {
                var genreCommunity = new GenreCommunity
                {
                    GenreName = createGenreCommunity.GenreName
                };
                _context.GenreCommunities.Add(genreCommunity);
                await _context.SaveChangesAsync();

                return new ResponeModel.ResponeModel { Status = "Success", Message = "Added new genre successfully", DataObject = genreCommunity };

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return new ResponeModel.ResponeModel { Status = "Error", Message = "An error occurred while adding the report" };
            }
        }
    }
}
