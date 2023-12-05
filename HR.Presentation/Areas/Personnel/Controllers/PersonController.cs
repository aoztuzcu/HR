using AutoMapper;
using HR.Application.Features.People.Commands.PersonUpdate;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Application.Features.Permission.Command.CreatePermissionRequest;
using HR.Application.Features.Permission.Queries;
using HR.Application.Features.Permission.ViewModels;
using HR.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace HR.Presentation.Areas.Person.Controllers;
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
    public async Task<IActionResult> Index(GetPersonByIdQuery query)
    {
        query.Id = Guid.Parse("33CCC344-64C0-4667-A5A0-E0B49031887B");
        var result = await mediator.Send(query);
        return View(result);
    }

    public async Task<IActionResult> UpdatePerson(Guid id)
    {
        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = id };
        var result = await mediator.Send(query);
        return View(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdatePerson(PersonUpdateCommand personUpdateCommand)
    {
        //GetPersonQuery query = new GetPersonQuery() { Id = personDetailVM.Id };
        //var result = await mediator.Send(personUpdateCommand);

        //var updateResult = mapper.Map<PersonUpdateCommand>(result);
        //updateResult.Id = personDetailVM.Id;
        if (personUpdateCommand.PhotoFile != null)
        {
            personUpdateCommand.Photo = FileOperation.ReturnFileName(personUpdateCommand.PhotoFile, "photos", webHostEnvironment);
        }
        //updateResult.Address = personDetailVM.Address;
        //updateResult.PhoneNumber = personDetailVM.PhoneNumber;

        await mediator.Send(personUpdateCommand);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Detail(Guid id)
    {
        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = id };
        var result = await mediator.Send(query);
        return View(result);
    }
    public async Task<IActionResult> PermissionRequestList(Guid id)
    {
        GetPermissionListQuery permissionList = new GetPermissionListQuery() { PersonelId = id };
        var result = await mediator.Send(permissionList);
        return View(result);
    }
    public async Task<IActionResult>CreatePermissionRequest(Guid id)
    {
    CreatePermissionRequestCommand command = new CreatePermissionRequestCommand() { PersonId = id };
        var result = await mediator.Send(command);

        return View(command);
    }
    [HttpPost]
    public async Task<IActionResult> CreatePermissionRequest(PermissionRequestCreateVM permissionRequestCreateVM)
    {
        if(ModelState.IsValid)
        {


            return RedirectToAction("İzin oluşturuldu.");
        }
        return View(permissionRequestCreateVM);
    }
}

