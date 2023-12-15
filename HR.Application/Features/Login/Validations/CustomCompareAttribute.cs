using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.Login.Validations
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class CustomCompareAttribute : ValidationAttribute
    {
        private readonly string _otherProperty;

        public CustomCompareAttribute(string otherProperty, string errorMessage)
            : base(errorMessage)
        {
            _otherProperty = otherProperty;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var otherPropertyInfo = validationContext.ObjectType.GetProperty(_otherProperty);

            if (otherPropertyInfo == null)
            {
                return new ValidationResult($"Property {_otherProperty} not found.");
            }

            var otherValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance);

            if (object.Equals(value, otherValue))
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
            
        }
    }
}
