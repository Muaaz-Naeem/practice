using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Empty.Models
{
    public class RegisterModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Enter EmailId")]
        //Using Remote validation attribute   
        [Remote("IsAlreadySigned", "Home", HttpMethod = "POST", ErrorMessage = "EmailId already exists in database.")]
        public string UserEmailId { get; set; }
        [Required]
        public string Designation { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = ("Choose Password"))]
        public string PassWord { get; set; }
    }
}