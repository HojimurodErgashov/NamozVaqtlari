using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace NamozVaqtlari.Validation
{
    public class PasswordValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Parol kiritilmagan.");
            }

            string phoneNumber = value.ToString();

            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).{10}$";

            if (!Regex.IsMatch(phoneNumber, pattern))
            {
                return new ValidationResult("Parol kamida 1 ta katta harf, 1 ta kichik harf, 1 ta raqam, 1 ta maxsus belgi va 10 ta belgidan iborat bo'lishi kerak.");
            }

            return ValidationResult.Success;
        }
    }
}
