using HR.Application.Features.People.Commands.PersonUpdate;
using HR.Application.Features.People.Queries.GetlAllPerson;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HR.Presentation.Areas.Manager.Controllers
{
    [Area("Manager")]
    [Authorize(Roles ="Manager")]
    public class ManagerController : Controller
    {
        private readonly IMediator mediator;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ManagerController(IMediator mediator, IWebHostEnvironment webHostEnvironment)
        {
            this.mediator = mediator;
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };//Guid.Parse("93CFE4FE-5E7C-462E-9655-350A1C87B53D") };
            var result = await mediator.Send(query);
            ViewBag.UserProfilePicture = result.Photo;
            ViewBag.UserProfileId = result.Id;
            return View(result);
        }


        public async Task<IActionResult> UpdateManager()//Guid id)
        {
            GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
            var result = await mediator.Send(query);
            ViewBag.UserProfilePicture = result.Photo;
            ViewBag.UserProfileId = result.Id;
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateManager(PersonUpdateCommand personUpdateCommand)
        {
            if (personUpdateCommand.PhotoFile != null)
            {
                personUpdateCommand.Photo = FileOperation.ReturnFileName(personUpdateCommand.PhotoFile, "photos", webHostEnvironment);
            }
            await mediator.Send(personUpdateCommand);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DetailManager()
        {
            GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
            var result = await mediator.Send(query);
            ViewBag.UserProfilePicture = result.Photo;
            ViewBag.UserProfileId = result.Id;
            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> PersonnelList()
        {
            GetAllPersonQuery query = new GetAllPersonQuery();
            var result = await mediator.Send(query); 
            return View(result);
        }

    }
}
