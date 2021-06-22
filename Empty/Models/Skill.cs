﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empty.Models
{
    public class Skill
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }

    }
}