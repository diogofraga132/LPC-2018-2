using AutoMapper;
using crud_people.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_people.Mapping
{
    public class AutomapperProfile : Profile
    {

        public AutomapperProfile()
        {
            CreateMap<Person, PersonViewModel>();
            CreateMap<PersonViewModel,Person>();
        }
    }
}
