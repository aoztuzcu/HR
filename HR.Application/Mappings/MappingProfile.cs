using AutoMapper;
using HR.Application.Features.AdvancePayments.Commands.CreateAdvancePayment;
using HR.Application.Features.AdvancePayments.Commands.DeleteByIdAdvancePayment;
using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.Departments.ViewModels;
using HR.Application.Features.Expenditures.Commands.CreateExpenditure;
using HR.Application.Features.EnumViewModels;
using HR.Application.Features.Expenditures.ViewModels;
using HR.Application.Features.Jobs.ViewModels;
using HR.Application.Features.People.Commands.PersonUpdate;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using HR.Application.Features.Permission.ViewModels;
using HR.Application.Features.Permission.Command.CreatePermissionRequest;

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
        CreateMap<AdvancePayment, DeleteByIdAdvancePaymentCommand>().ReverseMap();
        CreateMap<AdvancePaymentCreateVM, CreateAdvancePaymentCommand>().ReverseMap();
        CreateMap<AdvancePayment,AdvancePaymentListVM>().ReverseMap();


        CreateMap<Expenditure,CreateExpenditureCommand >().ReverseMap();
        CreateMap<ExpenditureCreateVM, CreateExpenditureCommand>().ReverseMap();
        CreateMap<Expenditure, ExpenditureCreateVM>().ReverseMap();
        CreateMap<Expenditure, ExpenditureListVM>().ReverseMap();

        CreateMap<PermissionRequestCreateVM, CreatePermissionRequestCommand>().ReverseMap();
        CreateMap<PermissionRequest, CreatePermissionRequestCommand>().ReverseMap();
        CreateMap<PermissionRequest, PermissionRequestListVM>().ReverseMap();
        CreateMap<Permission, PermissionTypeVM>().ReverseMap();

        //ViewModel Mappings
        CreateMap<ApprovalStatus, ApprovalStatusVM>().ReverseMap();
        CreateMap<CurrencyType, CurrencyTypeVM>().ReverseMap();
        CreateMap<AdvanceType, AdvanceTypeVM>().ReverseMap();
    }
}
