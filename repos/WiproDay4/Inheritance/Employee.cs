﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public virtual void display()
        {
            Console.WriteLine(EmpId + " " + EmpName);
        }
    }
}
