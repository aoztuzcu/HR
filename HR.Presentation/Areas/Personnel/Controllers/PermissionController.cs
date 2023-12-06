using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Permission.Command.CreatePermissionRequest;
using HR.Application.Features.Permission.Queries.GetPermissionRequestListByPersonId;
using HR.Application.Features.Permission.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HR.Presentation.Areas.Personnel.Controllers;

[Area("Personnel")]
[Authorize]
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
    public async Task<IActionResult> GetAllPermissions(Guid personnelId)
    {
        personnelId = Guid.Parse("8ECFEF55-CDF7-4D14-9B23-F6DB64FEC8B4");
        GetPermissionRequestListByPersonIdQuery query = new GetPermissionRequestListByPersonIdQuery() { PersonnelId = personnelId };
        var list = await mediator.Send(query);
        return View(list);
    }
    public async Task<IActionResult> CreatePermissionRequest()
    {
        var list = await permissionTypeRepository.GetAllAsync();
        var permissionList = mapper.Map<IEnumerable<PermissionTypeVM>>(list);
        var permissionRequestVM = new PermissionRequestCreateVM { PermissionList= permissionList };
        return View(permissionRequestVM);
    }
    [HttpPost]
    public async Task<IActionResult> CreatePermissionRequest(PermissionRequestCreateVM permissionRequestVM)
    {
        permissionRequestVM.PersonnelId = Guid.Parse("8ECFEF55-CDF7-4D14-9B23-F6DB64FEC8B4");
        var command = mapper.Map<CreatePermissionRequestCommand>(permissionRequestVM);
        var result = await mediator.Send(command);
        return RedirectToAction("GetAllPermissions", "Permission");
    }
}
