using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Enum;
using Repository.ViewModels.Person;
using Services.Interface;

namespace BE_Project_Exe201.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonServices _personService;

        public PersonController(IPersonServices personService)
        {
            _personService = personService;
        }

       
        [HttpGet("email")]
        public async Task<ActionResult<PersonModel>> GetPersonByEmail(string email)
        {
            var data = await _personService.GetPersonByEmail(email);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("SignIn")]
        public async Task<ActionResult> SignInAccountAsync(SignInModel signInModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _personService.SignInAccountAsync(signInModel);
                if (result.Status.Equals(false))
                {
                    //return Unauthorized();
                    ModelState.AddModelError(string.Empty, result.Message);
                    return ValidationProblem(ModelState);
                }
                return Ok(result);
            }
            return ValidationProblem(ModelState);
        }

        [HttpPost("SignUpPerson")]
        public async Task<ActionResult> SignUp(SignUpModel signUpModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _personService.SignUpAccountAsync(signUpModel);
                if (result.Status.Equals("Success"))
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return ValidationProblem(ModelState);
        }
    }
}
