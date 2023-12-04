using FluentValidation;
using HR.Application.Features.AdvancePayments.ViewModels;

namespace HR.Application.Features.AdvancePayments.Commands.CreateAdvancePayment;

public class CreateAdvancePaymentCommandValidator : AbstractValidator<CreateAdvancePaymentCommand>
{
    public CreateAdvancePaymentCommandValidator()
    {
        RuleFor(r => r.Amount).NotEmpty().WithMessage("Amount is required.")
                              .NotNull()
                              .GreaterThan(0).WithMessage("Amount must be grater than zero.");
        //.LessThanOrEqualTo(50000).WithMessage("Amount must not exceed.")
        //.Must((obj, amount) => BeAValidAmountForCurrency(obj.CurrencyType, amount)).WithMessage("Amount limits have been exceeded.");

        //RuleFor(r => r.AdvanceType).IsInEnum();
        //RuleFor(r => r.CurrencyType).IsInEnum();
        //RuleFor(r => r.ApprovalStatus).IsInEnum();

        RuleFor(r => r.Description).NotEmpty().WithMessage("Description is required.")
                                   .NotNull()
                                   .MinimumLength(3)
                                   .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");
    }

    //private bool BeAValidAmountForCurrency(CurrencyTypeVM currencyType, decimal amount)
    //{
    //    switch (currencyType)
    //    {
    //        case CurrencyTypeVM.Dolar:
    //            return amount <= 20000;
    //        case CurrencyTypeVM.Euro:
    //            return amount <= 18000;
    //        case CurrencyTypeVM.TL:
    //            return amount <= 50000;
    //        default:
    //            return false;
    //    }
    //}
}
