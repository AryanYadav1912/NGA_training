using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Department : Employee
    {
        public string Dept {  get; set; }
        public int Salary { get; set; }

        public override void display()
        {
            base.display();
            Console.WriteLine(Dept + " " +  Salary);
        }
    }
}
