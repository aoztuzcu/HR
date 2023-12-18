using AutoMapper;
using HR.Application.Features.Expenditures.Commands.ApproveExpenditureRequest;
using HR.Application.Features.Expenditures.Commands.RejectExpenditureRequest;
using HR.Application.Features.Expenditures.Queries.GetExpenditureRequestList;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Application.Features.Permission.Command.ApprovePermissionRequest;
using HR.Application.Features.Permission.Command.RejectPermissionRequest;
using HR.Application.Features.Permission.Queries.GetPermissionRequestList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace HR.Presentation.Areas.Manager.Controllers
{
    [Area("Manager")]
    [Authorize(Roles = "Manager")]
    public class RequestController : Controller
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment hostEnvironment;

        public RequestController(IMediator mediator, IMapper mapper, IWebHostEnvironment hostEnvironment)
        {
            this.mediator = mediator;
            this.mapper = mapper;
            this.hostEnvironment = hostEnvironment;
        }


        // İzin Talep Onay İşlemleri
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


        // Harcama Talep Onay İşlemleri
        public async Task<IActionResult> ExpenditureRequestApprove()
        {
            GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
            var result = await mediator.Send(query);
            ViewBag.UserProfilePicture = result.Photo;
            //ViewBag.UserProfileId = result.Id;

            var list = await mediator.Send(new GetExpenditureRequestListQuery());
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> ApproveByIdExpenditureRequest(Guid expenditureRequestId)
        {
            var result = await mediator.Send(new ApproveExpenditureRequestCommand() { ExpenditureId = expenditureRequestId });
            return RedirectToAction("ExpenditureRequestApprove");
        }

        [HttpGet]
        public async Task<IActionResult> RejectByIdExpenditureRequest(Guid expenditureRequestId)
        {
            var result = await mediator.Send(new RejectExpenditureRequestCommand() { ExpenditureId = expenditureRequestId });
            return RedirectToAction("ExpenditureRequestApprove");
        }

        public IActionResult ViewDocument(string documentPath)
        {
            if (!string.IsNullOrEmpty(documentPath))
            {
                string filePath = Path.Combine(hostEnvironment.WebRootPath, "expenditureFile", documentPath);
                if (System.IO.File.Exists(filePath))
                {
                    byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
                    string contentType = GetContentType(documentPath); // Belge türüne bağlı olarak MIME türünü al
                    string fileName = Path.GetFileName(documentPath);

                    return File(fileBytes, contentType);
                }
                else
                {
                    return NotFound();
                }
            }
            return NotFound();
        }
        private string GetContentType(string fileName)
        {
            string ext = Path.GetExtension(fileName)?.ToLowerInvariant();
            switch (ext)
            {
                case ".pdf":
                    return "application/pdf";
                case ".jpg":
                    return "image/jpeg";
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";
                default:
                    return "application/octet-stream"; // Varsayılan MIME türü
            }
        }
    }
}

