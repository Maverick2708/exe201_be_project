using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.Configuration.Annotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Repository.ViewModels.Person
{
    public class SignInModel
    {
        [Required(ErrorMessage = "Email can not be blank!"), EmailAddress(ErrorMessage = "Please enter valid email!")]
        public String AccountEmail { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password can not be blank!")]
        [DataType(DataType.Password)]
        [PasswordPropertyText]
        public string AccountPassword { get; set; } = string.Empty;
    }
    public class AuthenticationResponseModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public string JwtToken { get; set; }
        [Ignore]
        [IgnoreDataMember]
        [JsonIgnore]
        public Task<String>? VerifyEmailToken { get; set; }
        public DateTime? Expired { get; set; }
        public string JwtRefreshToken { get; set; }
    }
    public class PersonModel
    {
        public string? Id { get; set; }
        [Required(ErrorMessage = "FullName name is required!")]
        [Display(Name = "Name")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Phone number is required!")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phone Number!")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Phone Number!")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Date of Birth is required!")]
        [Display(Name = "Date of Birth")]
        public DateTime? Dob { get; set; }
        public string? Avatar { get; set; }
        public string? BackgroundImg { get; set; }
        public bool? Gender { get; set; }
        public string? Address { get; set; }
        public bool? IsVerifiedPage { get; set; }
    }
}
