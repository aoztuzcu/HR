using HR.Application.Features.People.Queries.GetPerson;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HR.Presentation.Controllers
{
    public class PersonController : Controller
    {
        private readonly IMediator mediator;
        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;   
        }
        public async Task<IActionResult> Index(GetPersonQuery query)
        {
            query.Id = Guid.Parse("78516AFA-1058-4808-8DA2-6B79DC0592FB");
            var result = await mediator.Send(query);
            return View(result);
        }
        //public async Task<IActionResult> Update(GetPersonQuery query)
        //{
        //    query.Id = Guid.Parse("B6F37500-CFD3-4968-9D76-71091665E28A");
        //    var result = await mediator.Send(query);
        //    return View(result);
        //}
        public async Task<IActionResult> Detail()
        {
            return View();
        }

    }
}
