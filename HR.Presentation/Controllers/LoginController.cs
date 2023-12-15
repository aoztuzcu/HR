using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Login;
using HR.Application.Features.People.Queries.GetPerson;
using HR.Domain.Concrete.Identity;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HR.Presentation.Controllers;

public class LoginController : Controller
{
    private readonly SignInManager<User> signInManager;
    private readonly UserManager<User> userManager;
    private readonly IPasswordHasher<User> passwordHasher;

    // giriş yapan kullanıcının PersonelId'sini bulmam gerekiyor
    private readonly IPersonnelRepository personnelRepository;

    public LoginController(SignInManager<User> signInManager, UserManager<User> userManager, IPersonnelRepository personnelRepository, IPasswordHasher<User> passwordHasher)
    {
        this.signInManager = signInManager;
        this.userManager = userManager;
        this.personnelRepository = personnelRepository;
        this.passwordHasher = passwordHasher;
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
            if (user == null)
            {
                TempData["ErrorMessage"] = "Parola veya mail yanlış.";
                return RedirectToAction("Login1", "Login");
            }

            var result = await signInManager.PasswordSignInAsync(user.UserName, person.Password, false, true);
            if (result.Succeeded)
            {
                // Kullanıcının e-mail'i doğrulanmadıysa (confirm edilmediyse)
                if (!user.EmailConfirmed)
                {
                    return RedirectToAction("UpdatePassword", "Login");
                }
                var personnel = await personnelRepository.GetAsync(f => f.UserId == user.Id, new CancellationToken());
                HttpContext.Session.SetString("PersonnelId", personnel.Id.ToString());
                if (await userManager.IsInRoleAsync(user, "Personnel"))
                {
                    return RedirectToAction("Index", "Person", new { area = "Personnel" });
                }
                // Rolü yönetici ise
                else if (await userManager.IsInRoleAsync(user, "Manager"))
                {
                    return RedirectToAction("Index", "Manager", new { area = "Manager" });
                }
                //else
                //{
                //    return RedirectToAction("Index", "Blog");
                //}
            }
            else
            {
                TempData["ErrorMessage"] = "Parola veya mail yanlış.";
                return RedirectToAction("Login1", "Login");
            }
        }
        TempData["ErrorMessage"] = "Parola veya mail yanlış.";
        return RedirectToAction("Login1", "Login");
    }

    [HttpGet]
    public IActionResult UpdatePassword()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> UpdatePassword(UserPasswordUpdateVM userPasswordUpdateVM)
    {
        if (!ModelState.IsValid)
        {
            return View(userPasswordUpdateVM);
        }

        // Kullanıcının kimlik doğrulamasını kontrol et
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var user = await userManager.FindByIdAsync(userId.ToString());

        if (user == null)
        {
            // Kullanıcı bulunamazsa hata mesajı veya uygun bir işlem yapılabilir.
            // Örneğin, ModelState.AddModelError("NotFound", "Kullanıcı bulunamadı."); 
            return RedirectToAction("Login1", "Login");
        }

        // Mevcut şifreyi doğrula
        var passwordCheckResult = await userManager.CheckPasswordAsync(user, userPasswordUpdateVM.CurrentPassword);

        if (!passwordCheckResult)
        {
            // Mevcut şifre yanlışsa hata mesajı veya uygun bir işlem yapılabilir.
            // Örneğin, ModelState.AddModelError("InvalidPassword", "Mevcut şifre yanlış."); 
            return RedirectToAction("Login1", "Login");
        }

        // Yeni şifreleri ayarla
        user.EmailConfirmed = true;
        user.PasswordHash = passwordHasher.HashPassword(user, userPasswordUpdateVM.NewPassword);

        // Kullanıcı bilgilerini güncelle
        var updateResult = await userManager.UpdateAsync(user);

        if (!updateResult.Succeeded)
        {
            // Kullanıcı güncellenemediyse hata mesajı veya uygun bir işlem yapılabilir.
            // Örneğin, ModelState.AddModelError("UpdateFailed", "Şifre güncellenemedi."); 
            return RedirectToAction("Login1", "Login");
        }

        return RedirectToAction("Login1", "Login");
    }


    public async Task<IActionResult> LogOut()
    {
        await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
        return RedirectToAction("Login1", "Login");
    }
    //public async static Task<string> GetUserProfilePicturePath()
    //{
    //    var personnel = await personnelRepository.GetAsync(f => f.UserId == userId, new CancellationToken());
    //    return personnel.Photo;
    //}

}
