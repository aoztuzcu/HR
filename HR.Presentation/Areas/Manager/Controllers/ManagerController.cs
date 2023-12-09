using Microsoft.AspNetCore.Mvc;

namespace HR.Presentation.Areas.Manager.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
