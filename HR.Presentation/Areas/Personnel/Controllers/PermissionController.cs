using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.AdvancePayments.Commands.DeleteByIdAdvancePayment;
using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Application.Features.Permission.Command.CreatePermissionRequest;
using HR.Application.Features.Permission.Command.DeleteByIdPermissionRequest;
using HR.Application.Features.Permission.Queries.GetPermissionRequestListByPersonId;
using HR.Application.Features.Permission.Queries.GetPermissionTypesList;
using HR.Application.Features.Permission.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HR.Presentation.Areas.Personnel.Controllers;

[Area("Personnel")]
[Authorize(Roles = "Personnel")]
public class PermissionController : Controller
{
    private readonly IMediator mediator;
    private readonly IMapper mapper;
    private readonly IPermissionTypeRepository permissionTypeRepository;
    public PermissionController(IMediator mediator, IMapper mapper, IPermissionTypeRepository permissionTypeRepository)
    {
        this.mediator = mediator;
        this.mapper = mapper;
        this.permissionTypeRepository = permissionTypeRepository;

    }
    [HttpGet]
    public async Task<IActionResult> GetAllPermissions()
    {   
        GetPermissionRequestListByPersonIdQuery query = new GetPermissionRequestListByPersonIdQuery() { PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var list = await mediator.Send(query);
        GetPersonByIdQuery query2 = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var personnel = await mediator.Send(query2);
        ViewBag.PersonnelProfilePicture = personnel.Photo;
        return View(list);
    }
    [HttpGet]
    public async Task<IActionResult> CreatePermissionRequest()
    {
        GetPermissionTypesListQuery query = new GetPermissionTypesListQuery() { PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var list = await mediator.Send(query);
       GetPersonByIdQuery query2 = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var personnel = await mediator.Send(query2);
        ViewBag.PersonnelProfilePicture = personnel.Photo;
        return View(new PermissionRequestCreateVM { PermissionList=list});
    }

    [HttpPost]
    public async Task<IActionResult> CreatePermissionRequest(PermissionRequestCreateVM permissionCreateVM)
    {
        if (permissionCreateVM.Days == 0)
        {
            var permissionType= await permissionTypeRepository.GetByIdAsync(permissionCreateVM.PermissionTypeId);
            permissionCreateVM.Days = (float)permissionType.Days;
        }
        if (!ModelState.IsValid)
        {
            List<Tuple<string, string>> validationErrors = new List<Tuple<string, string>>();

            // ModelState içindeki hataları döngüyle alıyoruz
            foreach (var entry in ModelState)
            {
                string propertyName = entry.Key;
                ModelErrorCollection errors = entry.Value.Errors;

                foreach (var error in errors)
                {
                    validationErrors.Add(new Tuple<string, string>(propertyName, error.ErrorMessage));
                }
            }
            return View(permissionCreateVM);
            //throw new Exception("Model not correct");
        }

        permissionCreateVM.PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId"));
        await mediator.Send(mapper.Map<CreatePermissionRequestCommand>(permissionCreateVM));
        return RedirectToAction("GetAllPermissions");
    }

    [HttpGet]
    public async Task<IActionResult> DeleteByIdPermissionRequest(Guid permissionRequestId)
    {
        var result = await mediator.Send(new DeleteByIdPermissionRequestCommand() { PermissionRequestId = permissionRequestId });
        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var personnel = await mediator.Send(query);
        ViewBag.PersonnelProfilePicture = personnel.Photo;
        return RedirectToAction("GetAllPermissions", "Permission");
    }
}
