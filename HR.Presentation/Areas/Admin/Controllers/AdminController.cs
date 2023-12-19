using HR.Application.Features.People.Commands.PersonUpdate;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HR.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class AdminController : Controller
    {
        private readonly IMediator mediator;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AdminController(IMediator mediator, IWebHostEnvironment webHostEnvironment)
        {
            this.mediator = mediator;
            this.webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
            var result = await mediator.Send(query);
            ViewBag.AdminProfilePicture = result.Photo;
            return View(result);
        }
        public async Task<IActionResult> DetailAdmin()
        {
            GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
            var result = await mediator.Send(query);
            ViewBag.AdminProfilePicture = result.Photo;
            return View(result);
        }
        public async Task<IActionResult> UpdateAdmin()
        {
            GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId"))};
            var result = await mediator.Send(query);
            ViewBag.AdminProfilePicture = result.Photo;
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAdmin(PersonUpdateCommand personUpdateCommand)
        {
            if (personUpdateCommand.PhotoFile != null)
            {
                personUpdateCommand.Photo = FileOperation.ReturnFileName(personUpdateCommand.PhotoFile, "photos",webHostEnvironment);
            }
            await mediator.Send(personUpdateCommand);
            return RedirectToAction("Index");
        }
    }
}
