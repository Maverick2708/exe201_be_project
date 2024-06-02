using Repository.ViewModels.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IPersonRepository
    {
        public Task<AuthenticationResponseModel> SignInAccountAsync(SignInModel signInModel);
        public Task<PersonModel> GetPersonByEmail(string email);
        public Task<ResponeModel.ResponeModel> SignUpAccountAsync(SignUpModel signUpModel);


    }
}
