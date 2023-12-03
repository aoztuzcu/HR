using AutoMapper;
using HR.Application.Features.AdvancePayments.Commands.CreateAdvancePayment;
using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.Departments.ViewModels;
using HR.Application.Features.Jobs.ViewModels;
using HR.Application.Features.People.Commands.PersonUpdate;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using HR.Domain.Enum;

namespace HR.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Personnel, PersonDetailVM>().ReverseMap();
        CreateMap<Personnel, PersonUpdateCommand>().ReverseMap();        
        CreateMap<PersonDetailVM, PersonUpdateCommand>().ReverseMap();
        CreateMap<Personnel, PersonVM>().ReverseMap();
        CreateMap<Department, DepartmentVM>().ReverseMap();
        CreateMap<Job, JobVM>().ReverseMap();

        CreateMap<AdvancePayment, CreateAdvancePaymentCommand>().ReverseMap();
        CreateMap<AdvancePaymentCreateVM, CreateAdvancePaymentCommand>().ReverseMap();
        CreateMap<AdvancePayment,AdvancePaymentListVM>().ReverseMap();

        //ViewModel Mappings
        CreateMap<ApprovalStatus, ApprovalStatusVM>().ReverseMap();
        CreateMap<CurrencyType, CurrencyTypeVM>().ReverseMap();
        CreateMap<AdvanceType, AdvanceTypeVM>().ReverseMap();
    }
}
