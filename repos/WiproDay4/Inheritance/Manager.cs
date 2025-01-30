using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Manager : Department
    {
        public string mgrName { get; set; }

        public override void display()
        {
            base.display();
            Console.WriteLine("Manager name :"+mgrName);
        }
    }
}
