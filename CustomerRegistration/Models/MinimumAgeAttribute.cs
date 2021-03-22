using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CustomerRegistration.Models
{
    public class MinimumAgeAttribute : ValidationAttribute, IClientModelValidator
    {
        private int minYears;
        public MinimumAgeAttribute(int years)
        {
            minYears = years;
        }

        protected override ValidationResult IsValid(object value, ValidationContext ctx)
        {
            if (value is int)
            {
                if ((int)value >= 18)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(GetMsg(ctx.DisplayName));
        }

        public void AddValidation(ClientModelValidationContext ctx)
        {
            if (!ctx.Attributes.ContainsKey("data-val"))
                ctx.Attributes.Add("data-val", "true");
            ctx.Attributes.Add("data-val-minimumage-years",
                minYears.ToString());
            ctx.Attributes.Add("data-val-minimumage",
                GetMsg(ctx.ModelMetadata.DisplayName ?? ctx.ModelMetadata.Name));
        }

        private string GetMsg(string customerName) => base.ErrorMessage ??
                                              $"{customerName} must be at least {minYears} years ago.";
    }
}
