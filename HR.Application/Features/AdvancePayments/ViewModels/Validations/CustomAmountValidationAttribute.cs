using System.ComponentModel.DataAnnotations;

namespace HR.Application.Features.AdvancePayments.ViewModels.Validations
{

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class CustomAmountValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] memberNames = new string[] { validationContext.MemberName };

            decimal val = Convert.ToDecimal(value);

            AdvancePaymentCreateVM advancePaymentCreateVM = (AdvancePaymentCreateVM)validationContext.ObjectInstance;

            Dictionary<(CurrencyTypeVM, AdvanceTypeVM), decimal> maxAmounts = new Dictionary<(CurrencyTypeVM, AdvanceTypeVM), decimal>
            {
                {(CurrencyTypeVM.Dolar, AdvanceTypeVM.Personal), 15000 },
                {(CurrencyTypeVM.Dolar, AdvanceTypeVM.Corporate), 25000 },
                {(CurrencyTypeVM.Euro, AdvanceTypeVM.Personal), 12000 },
                {(CurrencyTypeVM.Euro, AdvanceTypeVM.Corporate), 15000 },
                {(CurrencyTypeVM.TL, AdvanceTypeVM.Personal), 50000 },
                {(CurrencyTypeVM.TL, AdvanceTypeVM.Corporate), 100000 }
            };

            // Verilen para birimi ve avans tipi için maksimum miktarı al
            decimal maxAmount = maxAmounts.GetValueOrDefault((advancePaymentCreateVM.CurrencyType, advancePaymentCreateVM.AdvanceType), 0);

            // Hata kontrolü
            if (advancePaymentCreateVM.Amount > maxAmount)
            {
                string errorMessage = string.Format("{0} avans talebi için miktar alanına maksimum {1:N2} {2} değer girebilirsiniz.",
                                                    advancePaymentCreateVM.AdvanceType.ToString(), maxAmount, GetCurrencySymbol(advancePaymentCreateVM.CurrencyType));
                return new ValidationResult(errorMessage);
            }
            return ValidationResult.Success;
        }
        private string GetCurrencySymbol(CurrencyTypeVM currencyType)
        {
            switch (currencyType)
            {
                case CurrencyTypeVM.Dolar:
                    return "$";
                case CurrencyTypeVM.Euro:
                    return "€";
                case CurrencyTypeVM.TL:
                    return "₺";
                default:
                    return "";
            }
        }
    }
}
