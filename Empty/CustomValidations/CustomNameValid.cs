using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empty.CustomValidations
{
    public class CustomNameValid:ValidationAttribute,IClientValidatable
    {
        private readonly string _chars;
        public CustomNameValid(string chars)
            : base("{0} contains invalid character.")
        {
            _chars = chars;
        }
        public CustomNameValid()
        {

        }
        protected override ValidationResult IsValid(object value,ValidationContext context)
        {   
            if (value.ToString().Contains("c") )
                return new ValidationResult("Name cannot have c...........");
            else
                return ValidationResult.Success;

        }
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
             
            var rule = new ModelClientValidationRule();
            rule.ErrorMessage = "Name cannot contain 'c'";
            rule.ValidationParameters.Add("chars","c");
              rule.ValidationType = "ch";
            yield return rule;


        }
    }
}