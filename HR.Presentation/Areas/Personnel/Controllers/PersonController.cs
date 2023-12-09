using AutoMapper;
using HR.Application.Features.People.Commands.PersonUpdate;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Application.Features.Permission.Command.CreatePermissionRequest;
using HR.Application.Features.Permission.Queries;
using HR.Application.Features.Permission.Queries.GetPermissionTypesList;
using HR.Application.Features.Permission.ViewModels;
using HR.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        //query.Id = Guid.Parse("93CFE4FE-5E7C-462E-9655-350A1C87B53D");
        var result = await mediator.Send(query);
        return View(result);
    }

    public async Task<IActionResult> UpdatePerson()//Guid id)
    {
        //GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = id };
        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var result = await mediator.Send(query);
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
        return View(result);
    }
    public async Task<IActionResult> PermissionRequestList()//Guid id)
    {
        //GetPermissionListQuery permissionList = new GetPermissionListQuery() { PersonelId = id };
        GetPermissionTypesListQuery permissionList = new GetPermissionTypesListQuery() { PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var result = await mediator.Send(permissionList);
        return View(result);
    }
    public async Task<IActionResult> CreatePermissionRequest()//Guid id)
    {
        //CreatePermissionRequestCommand command = new CreatePermissionRequestCommand() { PersonnelId = id };
        CreatePermissionRequestCommand command = new CreatePermissionRequestCommand() { PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var result = await mediator.Send(command);
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

