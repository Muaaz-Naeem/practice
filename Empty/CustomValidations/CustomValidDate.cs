using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Empty.CustomValidations
{
    public class CustomValidDate:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            var x=DateTime.Now;
            DateTime dateTime = Convert.ToDateTime(value);
            var ageInYears = (DateTime.Now.Year - dateTime.Year);

           
            return   ageInYears>= 18 ? ValidationResult.Success : new ValidationResult("You must be older than 18 years to register");
            // return dateTime<=DateTime.Now;

         }
    }
}