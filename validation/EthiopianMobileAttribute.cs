using  System.ComponentModel.DataAnnotations;
using  System.Text.RegularExpressions;

namespace AddisEats.Api.Validation;
public class EthiopianMobileAttribute: ValidationAttribute
{
    private static readonly Regex Pattern = new Regex(@"^(?:\+251|0)(?:9|7)\d{8}$", RegexOptions.Compiled);
    public EthiopianMobileAttribute()
    { 
        ErrorMessage= "Enter a Valid Ethiopian Mobile Number";
    }
    protected override ValidationResult IsValid(object ? value, ValidationContext validationContext)
    {
        if(value is string phoneNumber)
        {
            if(Pattern.IsMatch(phoneNumber))
            {
                return ValidationResult.Success;
            }
        }
        return new ValidationResult(ErrorMessage);
    }

}