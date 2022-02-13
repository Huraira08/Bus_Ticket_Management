﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Conductor : Employee
    {
        public Conductor(string name, string employeeID, string title, int salary)
            : base(name, employeeID, title, salary)
        {
            this.name = name;
            this.employeeID = employeeID;
            this.title = title;
            this.salary = salary;
        }

        public Bus Bus
        {
            get;
            set;
        }
    }
}