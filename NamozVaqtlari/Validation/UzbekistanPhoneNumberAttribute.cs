using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace NamozVaqtlari.Validation
{
    public class UzbekistanPhoneNumberAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Telefon raqami kiritilmagan.");
            }

            string phoneNumber = value.ToString();

            // Telefon raqami +998 bilan boshlanishi va keyin 9 ta raqam bo'lishi kerak
            string pattern = @"^\+998\d{9}$";

            if (!Regex.IsMatch(phoneNumber, pattern))
            {
                return new ValidationResult("Telefon raqami +998 va 9 ta raqamdan iborat bo'lishi kerak.");
            }

            return ValidationResult.Success;
        }
    }
}
