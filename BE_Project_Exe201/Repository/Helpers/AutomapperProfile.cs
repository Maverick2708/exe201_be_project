﻿using AutoMapper;
using Repository.Models;
using Repository.ViewModels.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Helpers
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<PersonModel, Person>().ReverseMap();
        }
    }
}
