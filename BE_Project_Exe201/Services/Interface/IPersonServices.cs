using Repository.ResponeModel;
using Repository.ViewModels.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IPersonServices
    {
        public Task<AuthenticationResponseModel> SignInAccountAsync(SignInModel signInModel);
        public Task<PersonModel> GetPersonByEmail(string email);
        public Task<ResponeModel> SignUpAccountAsync(SignUpModel signUpModel);
    }
}
