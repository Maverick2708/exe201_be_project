using Repository.Interface;
using Repository.ResponeModel;
using Repository.ViewModels.Person;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PersonServices : IPersonServices
    {
        private readonly IPersonRepository _personRepository;
        public PersonServices(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<AuthenticationResponseModel> SignInAccountAsync(SignInModel signInModel)
        {
            var result = await _personRepository.GetPersonByEmail(signInModel.AccountEmail);
            if (result != null)
            {
                return await _personRepository.SignInAccountAsync(signInModel);
            }
            return new AuthenticationResponseModel
            {
                Status = false,
                Message = "Your Account not valid! Please Sign Up to Connect",
                JwtToken = null,
                Expired = null
            };
        }
        public async Task<PersonModel> GetPersonByEmail(string email)
        {
            return await _personRepository.GetPersonByEmail(email);
        }
        public async Task<ResponeModel> SignUpAccountAsync(SignUpModel signUpModel)
        {
            return await _personRepository.SignUpAccountAsync(signUpModel);
        }
    }
}
