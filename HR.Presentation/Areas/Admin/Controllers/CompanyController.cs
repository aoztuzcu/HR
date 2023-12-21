using AutoMapper;
using HR.Application.Features.Companies.Commands.CreateCompany;
using HR.Application.Features.Companies.Queries.GetAllCompany;
using HR.Application.Features.Companies.Queries.GetManagerInCompany;
using HR.Application.Features.Companies.ViewModels;
using HR.Application.Features.People.Queries.GetlAllPerson;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HR.Presentation.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]

public class CompanyController : Controller
{
    private readonly IMediator mediator;
    private readonly IWebHostEnvironment webHostEnvironment;
    private readonly IMapper mapper;

    public CompanyController(IMediator mediator, IWebHostEnvironment webHostEnvironment, IMapper mapper)
    {
        this.mediator = mediator;
        this.webHostEnvironment = webHostEnvironment;
        this.mapper = mapper;
    }

    public async Task<IActionResult> Index() //Şİrket listele
    {
     
        var companies = await mediator.Send(new GetAllCompanyQuery());       
        return View(companies);

    }

    [HttpGet]
    public IActionResult CreateCompany()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CreateCompany(CompanyCreateVM vm)
    {
        if (vm.Logo != null)
        {
            vm.LogoUrl = FileOperation.ReturnFileName(vm.Logo, "photos", webHostEnvironment);
        }

        var command = mapper.Map<CreateCompanyCommand>(vm);
       await mediator.Send(command);
        return View();
    }
    [HttpGet]
    public async Task<IActionResult> ListCompanyManagers()
    {
        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var user = await mediator.Send(query);
        ViewBag.AdminProfilePicture = user.Photo;
        var result = await mediator.Send(new GetManagerInCompanyQuery());
        return View(result);
    }

}
