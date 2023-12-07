﻿using AutoMapper;
using HR.Application.Features.AdvancePayments.Commands.CreateAdvancePayment;
using HR.Application.Features.AdvancePayments.Commands.DeleteByIdAdvancePayment;
using HR.Application.Features.AdvancePayments.Queries.GetAdvancePaymentListByPersonId;
using HR.Application.Features.AdvancePayments.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HR.Presentation.Areas.Personnel.Controllers;

[Area("Personnel")]
[Authorize]
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
    public async Task<IActionResult> Index()//Guid personnelId)
    {
        GetAdvancePaymentListByPersonIdQuery query = new GetAdvancePaymentListByPersonIdQuery() { PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId")) };
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

        if (!ModelState.IsValid)
        {
            List<Tuple<string, string>> validationErrors = new List<Tuple<string, string>>();

            // ModelState içindeki hataları döngüyle alıyoruz
            foreach (var entry in ModelState)
            {
                string propertyName = entry.Key;
                ModelErrorCollection errors = entry.Value.Errors;

                foreach (var error in errors)
                {
                    validationErrors.Add(new Tuple<string, string>(propertyName, error.ErrorMessage));
                }
            }
            return View(advancePaymentCreateVM);
            //throw new Exception("Model not correct");
        }

        // Session'dan KullanıcıId çekildi
        advancePaymentCreateVM.PersonnelId = Guid.Parse(HttpContext.Session.GetString("PersonnelId"));
        //advancePaymentCreateVM.PersonnelId = Guid.Parse("93CFE4FE-5E7C-462E-9655-350A1C87B53D");
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
