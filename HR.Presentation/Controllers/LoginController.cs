using HR.Application.Features.Login;
using HR.Domain.Concrete.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HR.Presentation.Controllers
{
    public class LoginController : Controller
    {

        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        public LoginController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;

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
					if (await userManager.IsInRoleAsync(user,"Personnel"))
                    {
                        return RedirectToAction("Detail", "Person", new { area = "Personnel" });
                    }
                    else if (await userManager.IsInRoleAsync(user, "Writer"))
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "Writer" });
                    }
                    else
                    {
                        return RedirectToAction("Index", "Blog");
                    }

                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
        public IActionResult Login2()
        {
            return View();
        }
        public IActionResult Login3()
        {
            return View();
        }
    }
}
