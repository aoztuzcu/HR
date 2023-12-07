using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Login;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Domain.Concrete;
using HR.Domain.Concrete.Identity;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HR.Presentation.Controllers;

public class LoginController : Controller
{

    private readonly SignInManager<User> signInManager;
    private readonly UserManager<User> userManager;

    // giriş yapan kullanıcının PersonelId'sini bulmam gerekiyor
    //private readonly IMediator mediator;
    private readonly IPersonnelRepository personnelRepository;

    public LoginController(SignInManager<User> signInManager, UserManager<User> userManager, IPersonnelRepository personnelRepository)
    {
        this.signInManager = signInManager;
        this.userManager = userManager;
        this.personnelRepository = personnelRepository;
    }

    public IActionResult Login1()
    {
        return View(new UserSignInVM());
    }

    [HttpPost]
    public async Task<IActionResult> Login1(UserSignInVM person)
    {
        if (ModelState.IsValid)
        {
            var user = await userManager.FindByEmailAsync(person.Email);
            var result = await signInManager.PasswordSignInAsync(user.UserName, person.Password, false, true);
            if (result.Succeeded)
            {
                if (await userManager.IsInRoleAsync(user, "Personnel"))
                {
                    var personnel = await personnelRepository.GetAsync(f => f.UserId == user.Id, new CancellationToken());
                    //
                    HttpContext.Session.SetString("PersonnelId", personnel.Id.ToString());
                    return RedirectToAction("Index", "Person", new { area = "Personnel" });
                }
                else if (await userManager.IsInRoleAsync(user, "Writer"))
                {
                    return RedirectToAction("Index", "Dashboard", new { area = "Writer" });
                }
                //else
                //{
                //    return RedirectToAction("Index", "Blog");
                //}

            }
            else
            {
                return RedirectToAction("Index", "Login1");
            }
        }
        return RedirectToAction("Index", "Login1");
    }
    public IActionResult Login2()
    {
        return View();
    }
    public IActionResult Login3()
    {
        return View();
    }



    public async Task<IActionResult> LogOut()
    {
        await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
        return RedirectToAction("Login1");
    }
}
