using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Empty.Models
{
    public class TestModel
    {
        [UIHint("Currency")]

        public decimal Money { get; set; }
    }
}