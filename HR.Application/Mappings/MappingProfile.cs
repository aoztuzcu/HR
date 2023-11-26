using AutoMapper;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Mappings;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Person, PersonDetailVM>().ReverseMap();
        CreateMap<Person, PersonUpdateVM>().ReverseMap();
        CreateMap<Person, PersonVM>().ReverseMap();
        
    }
}
