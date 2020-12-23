using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class _18YearOldValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var user = (User)validationContext.ObjectInstance;

            var age = DateTime.Now.Year - user.DateOfBirth.Year;

            return (age < 18) 
                    ? new ValidationResult("User should be greater than 18 years") 
                    : ValidationResult.Success;
        }
    }
}
