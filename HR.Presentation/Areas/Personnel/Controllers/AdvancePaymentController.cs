using AutoMapper;
using HR.Application.Features.AdvancePayments.Commands.CreateAdvancePayment;
using HR.Application.Features.AdvancePayments.Commands.DeleteByIdAdvancePayment;
using HR.Application.Features.AdvancePayments.Queries.GetAdvancePaymentListByPersonId;
using HR.Application.Features.AdvancePayments.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        public async Task<IActionResult> Index(Guid personnelId)
        {
            personnelId = Guid.Parse("33CCC344-64C0-4667-A5A0-E0B49031887B");
            GetAdvancePaymentListByPersonIdQuery query = new GetAdvancePaymentListByPersonIdQuery() { PersonnelId = personnelId };
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
            // CustomValidationAttribute için eklenmiştir.
            //if (!ModelState.IsValid)
            //    throw new Exception("Model not correct");

            advancePaymentCreateVM.PersonnelId = Guid.Parse("33CCC344-64C0-4667-A5A0-E0B49031887B");
            var command = mapper.Map<CreateAdvancePaymentCommand>(advancePaymentCreateVM);
            var result = await mediator.Send(command);
            return RedirectToAction("Index", "AdvancePayment");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteByIdAdvancePayment(Guid advancePaymentId)
        {
            var result = await mediator.Send(new DeleteByIdAdvancePaymentCommand() { AdvancePaymentId = advancePaymentId });
            return RedirectToAction("Index", "AdvancePayment");
        }
    }
}
