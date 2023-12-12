﻿using AutoMapper;
using HR.Application.Features.AdvancePayments.Commands.DeleteByIdAdvancePayment;
using HR.Application.Features.Expenditures.Commands.CreateExpenditure;
using HR.Application.Features.Expenditures.Queries.GetExpenditureListByPersonId;
using HR.Application.Features.Expenditures.Queries.GetExpenditureType;
using HR.Application.Features.Expenditures.ViewModels;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Domain.Concrete;
using HR.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace HR.Presentation.Areas.Personnel.Controllers;

[Area("Personnel")]
[Authorize(Roles = "Personnel")]
public class ExpenditureController : Controller
{
    private readonly IMediator mediator;
    private readonly IMapper mapper;
    private readonly IWebHostEnvironment hostEnvironment;

    public ExpenditureController(IMediator mediator, IMapper mapper, IWebHostEnvironment hostEnvironment)
    {
        this.mediator = mediator;
        this.mapper = mapper;
        this.hostEnvironment = hostEnvironment;
    }
    public async Task<IActionResult> Index() //Guid personnelId)
    {
        //personnelId = Guid.Parse("93CFE4FE-5E7C-462E-9655-350A1C87B53D");
        //GetExpenditureListByPersonIdQuery query = new GetExpenditureListByPersonIdQuery() { PersonnelId = personnelId };
        GetExpenditureListByPersonIdQuery query = new GetExpenditureListByPersonIdQuery() { PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var list = await mediator.Send(query);
        GetPersonByIdQuery query2 = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var personnel = await mediator.Send(query2);
        ViewBag.PersonnelProfilePicture = personnel.Photo;
        return View(list);
    }

    [HttpGet]
    public async Task<IActionResult> CreateExpenditure()
    {
        ExpenditureCreateVM vm = new ExpenditureCreateVM();
        vm.ExpenditureTypes = await mediator.Send(new GetExpenditureTypeQuery());
        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var personnel = await mediator.Send(query);
        ViewBag.PersonnelProfilePicture = personnel.Photo;
        return View(vm);
    }
    [HttpPost]
    public async Task<IActionResult> CreateExpenditure(ExpenditureCreateVM vm)
    {
        var command = mapper.Map<CreateExpenditureCommand>(vm);
        command.PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId"));
        command.Document = FileOperation.ReturnFileName(vm.Document, "expenditureFile", hostEnvironment);
        await mediator.Send(command);
        return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult DeleteByIdExpenditure(Guid id)
    {
        return RedirectToAction("Index", "Expenditure");
    }
    public IActionResult DownloadDocument(string documentPath)
    {
        if (!string.IsNullOrEmpty(documentPath))
        {
            string filePath = Path.Combine(hostEnvironment.WebRootPath, "expenditureFile", documentPath);
            if (System.IO.File.Exists(filePath))
            {
                byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
                string fileName = documentPath;
                return File(fileBytes, "application/octet-stream", fileName);
            }
            else
            {
                return NotFound();
            }
        }
        return NotFound(); 
    }
}
