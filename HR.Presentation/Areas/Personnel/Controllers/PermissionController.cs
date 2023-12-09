using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Permission.Command.CreatePermissionRequest;
using HR.Application.Features.Permission.Queries.GetPermissionRequestListByPersonId;
using HR.Application.Features.Permission.Queries.GetPermissionTypesList;
using HR.Application.Features.Permission.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
    public async Task<IActionResult> GetAllPermissions()//Guid personnelId)
    {
        //personnelId = Guid.Parse("93CFE4FE-5E7C-462E-9655-350A1C87B53D");
        //GetPermissionRequestListByPersonIdQuery query = new GetPermissionRequestListByPersonIdQuery() { PersonnelId = personnelId };
        GetPermissionRequestListByPersonIdQuery query = new GetPermissionRequestListByPersonIdQuery() { PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var list = await mediator.Send(query);
        return View(list);
    }
    public async Task<IActionResult> CreatePermissionRequest()
    {
        GetPermissionTypesListQuery query = new GetPermissionTypesListQuery() { PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var list = await mediator.Send(query);
        return View(new PermissionRequestCreateVM { PermissionList=list});
    }

    [HttpPost]
    public IActionResult CreatePermissionRequest(PermissionRequestCreateVM permissionCreateVM)
    {
        permissionCreateVM.PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId"));
        var command = mapper.Map<CreatePermissionRequestCommand>(permissionCreateVM);
        var result = mediator.Send(command);
        return RedirectToAction("GetAllPermissions");
    }
}
