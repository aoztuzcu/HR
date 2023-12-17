using AutoMapper;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Application.Features.Permission.Command.ApprovePermissionRequest;
using HR.Application.Features.Permission.Command.RejectPermissionRequest;
using HR.Application.Features.Permission.Queries.GetPermissionRequestList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HR.Presentation.Areas.Manager.Controllers
{
    [Area("Manager")]
    [Authorize(Roles = "Manager")]
    public class RequestController : Controller
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public RequestController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        public async Task<IActionResult> PermissionRequestApprove()
        {
            GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
            var result = await mediator.Send(query);
            ViewBag.UserProfilePicture = result.Photo;
            //ViewBag.UserProfileId = result.Id;

            var list = await mediator.Send(new GetPermissionRequestListQuery());
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> ApproveByIdPermissionRequest(Guid permissionRequestId)
        {
            var result = await mediator.Send(new ApprovePermissionRequestCommand() { PermissionRequestId = permissionRequestId });
            return RedirectToAction("PermissionRequestApprove");
        }

        [HttpGet]
        public async Task<IActionResult> RejectByIdPermissionRequest(Guid permissionRequestId)
        {
            var result = await mediator.Send(new RejectPermissionRequestCommand() { PermissionRequestId = permissionRequestId });
            return RedirectToAction("PermissionRequestApprove");
        }
    }
}

