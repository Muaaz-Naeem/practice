using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empty.Models
{
    [MetadataType(typeof(StudentMetaData))]
    public partial class Student
    {
 
    }



    public class StudentMetaData
    {
        [Remote("IsAlreadyExist", "Home", HttpMethod = "POST", ErrorMessage = "User Already Available")]
        public String Name { get; set; }

    }

}