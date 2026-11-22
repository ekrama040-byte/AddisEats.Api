using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace AddisEats.Api.Validation;

public class ETBAmountAttribute: ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult.Success;
        }
       
        if(value is decimal amount && amount>=0m)
        {
          return ValidationResult.Success;
           
        }
        
        return new ValidationResult("amount must be a non-negative decimal");

        if(decimal.Round(amount,2) != amount)
        {
            return new ValidationResult("amount must have at most two decimal places");
        }
    }
}