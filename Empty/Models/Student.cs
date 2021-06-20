using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Empty.CustomValidations;
using Empty.Enum;

namespace Empty.Models
{
     public partial class Student:IValidatableObject
    {
        public int  ? ID { get; set; }

        [MaxLength(30, ErrorMessage = "Name cannot exceed 30 characters")]
        //[Required(ErrorMessage = "Please Enter Name")]

        [CustomNameValid("abc")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress) ]
        [Remote("IsAlreadySigned", "Home", HttpMethod = "POST", ErrorMessage = "EmailId already exists in database.")]

        public string UserEmailId { get; set; }

        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8}$",
        //     ErrorMessage = "        Password must contain One Capital letter, one Special character and minimam length should be 8 requirements")]
        //[Required(ErrorMessage = "Please type a Password"),MinLength(8, ErrorMessage ="Password must be minimam of 8 characters")]
        //[RegularExpression(@"(?=.*\d)(?=.*[A-Za-z]).{5,}", ErrorMessage = "Your password must be at least 5 characters long and contain at least 1 letter and 1 number")]
        [Required]
        public string Password { get; set; }
        
        [Display(Name ="Confirm Password")]
        //[System.ComponentModel.DataAnnotations.Compare(nameof(Password),ErrorMessage ="passwords mismatch")]
                    

        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please Specify Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please select a Section")]
        public int  SectionID { get; set; }

        public bool isActive{ get; set; }

        [MaxLength(150, ErrorMessage = "Autobiography cannot exceed 150 characters")]
        public string Autobiograpy { get; set; }

        [Required]
        [Range(1, 12, ErrorMessage = "Select  availability")]

        public Availablity Availability { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd yyyy}")]
        //[Required(ErrorMessage = "Please Select a Date Of Birth")]
        //[CustomValidDate]


        public DateTime DOB { get; set; }

        public Section section { get; set; }

        public HttpPostedFileBase Resume { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var property = new[] { "Name" };
               
            if (Name == null)
              yield return new ValidationResult("Name cannot be empty",property);
        }
    }
}