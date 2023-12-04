﻿using AutoMapper;
using HR.Application.Features.People.Commands.PersonUpdate;
using HR.Application.Features.People.Queries.GetPerson;
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
        query.Id = Guid.Parse("03C01409-DC14-4BBD-BD72-F895A53BB66C");
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
}

