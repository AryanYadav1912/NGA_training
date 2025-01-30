using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrfacePractice
{
    internal interface Shape
    {
        void CalculatedArea();
        void SquareArea(int side)
        {
            Console.WriteLine("Area of Square is : " + Math.Pow(side, 2));

        }
    }
    class Circle : Shape
    {
        public int radius { get; set; }
        void Shape.CalculatedArea()
        {
            Console.WriteLine("Area Of Circle is : " + Math.PI * Math.Pow(radius, 2));

        }
    }
    class rectangle : Shape
    {
        public int L { get; set; }
        public int B { get; set; }
        void Shape.CalculatedArea()
        {
            Console.WriteLine("Area Of Rectangle is: " + L * B);
        }
    }
}
