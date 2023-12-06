using FluentValidation;

namespace HR.Application.Features.Permission.Command.CreatePermissionRequest;

public class CreatePermissionRequestValidator : AbstractValidator<CreatePermissionRequestCommand>
{
    public CreatePermissionRequestValidator() 
    {
        RuleFor(x => x.StartDate)
                                .NotEmpty()
                                .WithMessage("Başlangıç tarihi girilmek zorundadır.")
                                .GreaterThanOrEqualTo(DateTime.Now.Date.AddDays(1))
                                .WithMessage("Başlangıç tarihi en erken yarın olabilir.");

        RuleFor(x => x.EndDate)
                                .NotEmpty().WithMessage("Bitiş tarihi girilmek zorundadır.")
                                .GreaterThanOrEqualTo(x => x.StartDate)
                                .WithMessage("İzin bitiş tarihi, başlangıç tarihinden büyük olmalıdır.");
    }
}
