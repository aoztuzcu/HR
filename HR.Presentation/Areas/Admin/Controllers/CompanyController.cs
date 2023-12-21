using AutoMapper;
using HR.Application.Contracts.Persistence.Services;
using HR.Application.Features.Companies.Commands.CreateCompany;
using HR.Application.Features.Companies.Queries.GetAllCompany;
using HR.Application.Features.Companies.Queries.GetCompanyById;
using HR.Application.Features.Companies.Queries.GetManagerInCompany;
using HR.Application.Features.Companies.ViewModels;
using HR.Application.Features.Departments.Queries.GetAllDepartmens;
using HR.Application.Features.Jobs.Queries.GetAllJobQuery;
using HR.Application.Features.People.Commands.PersonCreate;
using HR.Application.Features.People.Queries.GetlAllPerson;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete.Identity;
using HR.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PasswordGenerator;
using System.Security.Claims;

namespace HR.Presentation.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]

public class CompanyController : Controller
{
    private readonly IMediator mediator;
    private readonly IWebHostEnvironment webHostEnvironment;
    private readonly IMapper mapper;
    private readonly UserManager<User> userManager;
    private readonly IEmailService emailService;
    private readonly IPasswordHasher<User> passwordHasher;

    public CompanyController(IMediator mediator, IWebHostEnvironment webHostEnvironment, IMapper mapper, UserManager<User> userManager, IEmailService emailService, IPasswordHasher<User> passwordHasher)
    {
        this.mediator = mediator;
        this.webHostEnvironment = webHostEnvironment;
        this.mapper = mapper;
        this.userManager = userManager;
        this.emailService = emailService;
        this.passwordHasher = passwordHasher;
    }

    public async Task<IActionResult> Index() //Şİrket listele
    {
        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var result = await mediator.Send(query);
        ViewBag.AdminProfilePicture = result.Photo;
        var companies = await mediator.Send(new GetAllCompanyQuery());
        return View(companies);
    }

    [HttpGet]
    public async Task<IActionResult> CreateCompany()
    {

        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var result = await mediator.Send(query);
        ViewBag.AdminProfilePicture = result.Photo;
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
        return RedirectToAction("ListCompanyManagers", "Company");
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
    [HttpGet]
    public async Task<IActionResult> CreateManager()
    {
        GetPersonByIdQuery query = new GetPersonByIdQuery() { Id = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
        var result = await mediator.Send(query);
        ViewBag.AdminProfilePicture = result.Photo;
        PersonCreateVM vm = new PersonCreateVM()
        {
            Companies = await mediator.Send(new GetAllCompanyQuery()),
            Departments = await mediator.Send(new GetAllDepartmenQuery()),
            Jobs = await mediator.Send(new GetAllJobQuery()),
        };
        return View(vm);
    }
    [HttpPost]
    public async Task<IActionResult> CreateManager(PersonCreateVM vm)
    {
        var company = await mediator.Send(new GetCompanyByIdQuery() { Id = vm.CompanyId });
        vm.CompanyName = company.Name;
        //otomatik mail oluşturma 
        //var email = CharacterFix.Fix(vm.Name) + "." + CharacterFix.Fix(vm.Surname) + "@bilgeadam.com";
        var email = CharacterFix.Fix(vm.Name) + "." + CharacterFix.Fix(vm.Surname) + "@gmail.com";
        var existingUser = await userManager.FindByEmailAsync(email);

        if (existingUser != null)
        {
            // E-posta adresi zaten kullanılıyor
            TempData["ErrorMessage"] = "E-posta adresi zaten kullanılıyor.";
            return RedirectToAction("CreateManager", "Company");
        }
        var user = new User
        {
            UserName = Guid.NewGuid().ToString(),
            Email = email,
            Name = vm.Name,
            Surname = vm.Surname,
            NormalizedEmail = email.ToUpper(),

        };
        // Rastgele bir parola oluştur
        Password passwordGenarator = new Password();
        var password = passwordGenarator.Next();
        var hashedPassword = passwordHasher.HashPassword(user, password);
        user.PasswordHash = hashedPassword;

        var result = await userManager.CreateAsync(user);

        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(user, "Manager");
            // Kullanıcı başarıyla eklendi
            var recordUser = await userManager.FindByEmailAsync(email);
            vm.UserId = recordUser.Id;
            var command = mapper.Map<PersonCreateCommand>(vm);
            command.Photo = FileOperation.ReturnFileName(vm.Photo, "photos", webHostEnvironment);
            command.Email = email;
            var resultAdded = await mediator.Send(command);
            //mail gönderilicek
            var adminId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var admin = await userManager.FindByIdAsync(adminId.ToString());
            await emailService.SendConfirmMail(recordUser.Email, password, $"{admin.Name} {admin.Surname}");
            return RedirectToAction("Index", "Company");
        }
        else
        {
            // Kullanıcı eklenirken bir hata oluştu, hataları işleyebilirsiniz
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View();
        }
    }
}
