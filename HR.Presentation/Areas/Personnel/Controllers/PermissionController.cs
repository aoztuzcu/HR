using AutoMapper;
using HR.Application.Features.AdvancePayments.Commands.CreateAdvancePayment;
using HR.Application.Features.AdvancePayments.Queries.GetAdvancePaymentListByPersonId;
using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.Permission.Command.CreatePermissionRequest;
using HR.Application.Features.Permission.Queries.GetPermissionRequestListByPersonId;
using HR.Application.Features.Permission.ViewModels;
using HR.Domain.Concrete;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HR.Presentation.Areas.Personnel.Controllers
{
    public class PermissionController : Controller
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public PermissionController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPermissions(Guid personnelId)
        {
            personnelId = Guid.Parse("33CCC344-64C0-4667-A5A0-E0B49031887B");
            GetPermissionRequestListByPersonIdQuery query = new GetPermissionRequestListByPersonIdQuery() { PersonnelId = personnelId };
            var list = await mediator.Send(query);
            return View(list);
        }
        [HttpGet]
        public IActionResult CreatePermissionRequest()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePermissionRequest(PermissionRequestCreateVM permissionRequestVM)
        {
            permissionRequestVM.PersonnelId = Guid.Parse("33CCC344-64C0-4667-A5A0-E0B49031887B");
            var command = mapper.Map<CreatePermissionRequestCommand>(permissionRequestVM);
            var result = await mediator.Send(command);
            return RedirectToAction("GetAllPermissions", "Permission");
        }
    }
}
