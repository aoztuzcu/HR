using FluentValidation;
using System.Text.RegularExpressions;

namespace HR.Application.Features.People.Commands.PersonUpdate
{
    public class PersonUpdateCommandValidator : AbstractValidator<PersonUpdateCommand>
    {
        public PersonUpdateCommandValidator()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address is mandatory.");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone number is mandatory.")
                                       .Must(IsPhoneNumber).WithMessage("Please enter a valid phone number.");
        }

        private bool IsPhoneNumber(string arg)
        {
            Regex regex = new Regex(@"^[0-9]{10}$");
            return regex.IsMatch(arg);
        }
    }
}

