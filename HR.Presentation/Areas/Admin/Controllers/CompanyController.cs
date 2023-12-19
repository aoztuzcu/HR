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

    public CompanyController(IMediator mediator, IWebHostEnvironment webHostEnvironment)
    {
        this.mediator = mediator;
        this.webHostEnvironment = webHostEnvironment;
    }

    public IActionResult Index() //Şİrket listele
    {

        return View();
    }

   
}
