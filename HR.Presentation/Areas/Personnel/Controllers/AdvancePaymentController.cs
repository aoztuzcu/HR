using AutoMapper;
using HR.Application.Features.AdvancePayments.Commands.CreateAdvancePayment;
using HR.Application.Features.AdvancePayments.Queries.GetAdvancePaymentListByPersonId;
using HR.Application.Features.AdvancePayments.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HR.Presentation.Areas.Personnel.Controllers
{
    [Area("Personnel")]
    public class AdvancePaymentController : Controller
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public AdvancePaymentController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        [HttpGet]
        // Index sayfasında kullanıcıyı avans taleplerinin listelendiği sayfa karşılasın.
        public async Task<IActionResult> Index(Guid personId)
        {
            personId = Guid.Parse("03C01409-DC14-4BBD-BD72-F895A53BB66C");
            GetAdvancePaymentListByPersonIdQuery query = new GetAdvancePaymentListByPersonIdQuery() { PersonId = personId };
            var list = await mediator.Send(query);
            return View(list);
        }
        

        [HttpGet] //new AdvancePaymentCreateVM()
        public IActionResult CreateAdvancePayment()
        {
           return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdvancePayment(AdvancePaymentCreateVM advancePaymentCreateVM)
        {
            advancePaymentCreateVM.PersonId = Guid.Parse("03C01409-DC14-4BBD-BD72-F895A53BB66C");
            var command = mapper.Map<CreateAdvancePaymentCommand>(advancePaymentCreateVM);
            
            var result = await mediator.Send(command);
            return RedirectToAction("Index", "AdvancePayment");
        }
    }
}
