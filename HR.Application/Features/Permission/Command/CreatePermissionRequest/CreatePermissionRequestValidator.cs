using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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

        RuleFor(r => r.PermissionType).IsInEnum();
        RuleFor(r => r.ApprovalStatus).IsInEnum();
        
    }
}
