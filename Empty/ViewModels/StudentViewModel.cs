using Empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empty.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }

        public List<Section> sections;
     }
}