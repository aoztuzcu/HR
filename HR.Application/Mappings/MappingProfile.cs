using AutoMapper;
using HR.Application.Features.Departments.ViewModels;
using HR.Application.Features.Jobs.ViewModels;
using HR.Application.Features.People.Commands.PersonUpdate;
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
        //CreateMap<Person, PersonDetailVM>().ReverseMap();
        //CreateMap<Person, PersonUpdateCommand>().ReverseMap();        
        CreateMap<PersonDetailVM, PersonUpdateCommand>().ReverseMap();
        //CreateMap<Person, PersonVM>().ReverseMap();
        CreateMap<Department, DepartmentVM>().ReverseMap();
        CreateMap<Job, JobVM>().ReverseMap();
    }
}
