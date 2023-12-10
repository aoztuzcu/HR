using AutoMapper;
using HR.Application.Contracts.Persistence.Services;
using HR.Application.Features.Departments.Queries.GetAllDepartmens;
using HR.Application.Features.Jobs.Queries.GetAllJobQuery;
using HR.Application.Features.People.Commands.PersonCreate;
using HR.Application.Features.People.Commands.PersonUpdate;
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

namespace HR.Presentation.Areas.Manager.Controllers
{
    [Area("Manager")]
    [Authorize(Roles = "Manager")]
    public class ManagerController : Controller
    {
        private readonly IMediator mediator;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<User> userManager;
        private readonly IPasswordHasher<User> passwordHasher;
        private readonly IMapper mapper;
        private readonly IEmailService emailService;

        public ManagerController(IMediator mediator, IWebHostEnvironment webHostEnvironment, UserManager<User> userManager, IPasswordHasher<User> passwordHasher, IMapper mapper, IEmailService emailService)
        {
            this.mediator = mediator;
            this.webHostEnvironment = webHostEnvironment;
            this.userManager = userManager;
            this.passwordHasher = passwordHasher;
            this.mapper = mapper;
            this.emailService = emailService;
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
        [HttpGet]
        public async Task<IActionResult> CreatePersonnel()
        {
            GetAllDepartmenQuery departmenQuery = new GetAllDepartmenQuery();
            GetAllJobQuery jobQuery = new GetAllJobQuery();
            PersonCreateVM vm = new PersonCreateVM();
            vm.Departments = await mediator.Send(departmenQuery);
            vm.Jobs = await mediator.Send(jobQuery);
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePersonnel(PersonCreateVM vm)
        {
            var email = vm.Name.ToLower() + "." + vm.Surname.ToLower() + "@bilgeadamboost.com";

            // E-posta adresi zaten kullanımda mı kontrol et
            var existingUser = await userManager.FindByEmailAsync(email);

            if (existingUser != null)
            {
                // E-posta adresi zaten kullanılıyor
                TempData["ErrorMessage"] = "E-posta adresi zaten kullanılıyor.";
                return RedirectToAction("CreatePersonnel", "Manager");
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
                await userManager.AddToRoleAsync(user, "Personnel");
                // Kullanıcı başarıyla eklendi
                var recordUser = await userManager.FindByEmailAsync(email);
                vm.UserId = recordUser.Id;
                var command = mapper.Map<PersonCreateCommand>(vm);
                command.Photo = FileOperation.ReturnFileName(vm.Photo, "photos", webHostEnvironment);
                command.Email = email;
                var resultAdded = await mediator.Send(command);
                //mail gönderilicek
                var managerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var manager = await userManager.FindByIdAsync(managerId.ToString());
                await emailService.SendConfirmMail(recordUser.Email , password ,$"{manager.Name} {manager.Surname}");
                return RedirectToAction("PersonnelList", "Manager");
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
        //[HttpGet]
        //public async Task<IActionResult> MailAt()
        //{
        //    Password passwordGenarator = new Password();
        //    var password = passwordGenarator.Next();
        //    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    var manager = await userManager.FindByIdAsync(userId.ToString());
        //    await emailService.SendConfirmMail("aoztuzcu27@gmail.com" , password, $"{manager.Name} {manager.Surname}");

        //    return Ok();
        //}
    }
}
