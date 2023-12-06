﻿using AutoMapper;
using HR.Application.Features.AdvancePayments.Commands.DeleteByIdAdvancePayment;
using HR.Application.Features.Expenditures.Commands.CreateExpenditure;
using HR.Application.Features.Expenditures.Queries.GetExpenditureListByPersonId;
using HR.Application.Features.Expenditures.Queries.GetExpenditureType;
using HR.Application.Features.Expenditures.ViewModels;
using HR.Domain.Concrete;
using HR.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HR.Presentation.Areas.Personnel.Controllers
{
    [Area("Personnel")]
    [Authorize(Roles = "Personnel")]
    public class ExpenditureController : Controller
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment hostEnvironment;

        public ExpenditureController(IMediator mediator, IMapper mapper, IWebHostEnvironment hostEnvironment)
        {
            this.mediator = mediator;
            this.mapper = mapper;
            this.hostEnvironment = hostEnvironment;
        }
        public async Task<IActionResult> Index(Guid personnelId)
        {
            personnelId = Guid.Parse("8ECFEF55-CDF7-4D14-9B23-F6DB64FEC8B4");
            GetExpenditureListByPersonIdQuery query = new GetExpenditureListByPersonIdQuery() { PersonnelId = personnelId };
            var list = await mediator.Send(query);
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> CreateExpenditure()
        {
            ExpenditureCreateVM vm = new ExpenditureCreateVM();
            vm.ExpenditureTypes = await mediator.Send(new GetExpenditureTypeQuery());
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> CreateExpenditure(ExpenditureCreateVM vm)
        {
            var command = mapper.Map<CreateExpenditureCommand>(vm);
            command.Document = FileOperation.ReturnFileName(vm.Document, "expenditureFile", hostEnvironment);
            await mediator.Send(command);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteByIdExpenditure(Guid id)
        {
            // var result = await mediator.Send(new DeleteByIdAdvancePaymentCommand() { AdvancePaymentId = advancePaymentId });
            return RedirectToAction("Index", "Expenditure");
        }
    }
}