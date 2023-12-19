using AutoMapper;
using HR.Application.Features.People.Commands.PersonUpdate;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Application.Features.People.ViewModels;
using HR.Application.Features.Permission.Command.CreatePermissionRequest;
using HR.Application.Features.Permission.Queries;
using HR.Application.Features.Permission.Queries.GetPermissionTypesList;
using HR.Application.Features.Permission.ViewModels;
using HR.Domain.Concrete;
using HR.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HR.Presentation.Areas.Person.Controllers;

[Authorize(Roles = "Personnel")]
[Area("Personnel")]

public class PersonController : Controller
{
    private readonly IMediator mediator;
    private readonly IMapper mapper;
    private readonly IWebHostEnvironment webHostEnvironment;

    public PersonController(IMediator mediator, IMapper mapper, IWebHostEnvironment webHostEnvironment)
    {
        this.mediator = mediator;
        this.mapper = mapper;
        this.webHostEnvironment = webHostEnvironment;
    }

    public async Task<IActionResult> Index()//GetPersonByIdQuery query)
    {
        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var personnel = await mediator.Send(query);
        ViewBag.PersonnelProfilePicture = personnel.Photo;
        return View(personnel);
    }
    public async Task GetProfilePicturePath()
    {
        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var personnel = await mediator.Send(query);
        ViewBag.PersonnelProfilePicture = personnel.Photo;
    }
    public async Task<IActionResult> UpdatePerson()//Guid id)
    {
        //GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = id };
        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var result = await mediator.Send(query);
        ViewBag.PersonnelProfilePicture = result.Photo;
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdatePerson(PersonUpdateCommand personUpdateCommand)
    {
        if (personUpdateCommand.PhotoFile != null)
        {
			personUpdateCommand.Photo = FileOperation.ReturnFileName(personUpdateCommand.PhotoFile, "photos", webHostEnvironment);
        }
        await mediator.Send(personUpdateCommand);
        return RedirectToAction("Index");
    }
    public async Task<IActionResult> Detail()//Guid id)
    {
        //GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = id };
        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var result = await mediator.Send(query);
        ViewBag.PersonnelProfilePicture = result.Photo;
        return View(result);
    }
    public async Task<IActionResult> PermissionRequestList()//Guid id)
    {
        //GetPermissionListQuery permissionList = new GetPermissionListQuery() { PersonelId = id };
        GetPermissionTypesListQuery permissionList = new GetPermissionTypesListQuery() { PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var result = await mediator.Send(permissionList);
        GetProfilePicturePath();
        return View(result);
    }
    public async Task<IActionResult> CreatePermissionRequest()//Guid id)
    {
        //CreatePermissionRequestCommand command = new CreatePermissionRequestCommand() { PersonnelId = id };
        CreatePermissionRequestCommand command = new CreatePermissionRequestCommand() { PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var result = await mediator.Send(command);
        GetProfilePicturePath();
        return View(command);
    }
    [HttpPost]
    public async Task<IActionResult> CreatePermissionRequest(PermissionRequestCreateVM permissionRequestCreateVM)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("İzin oluşturuldu.");
        }
        return View(permissionRequestCreateVM);
    }
}

