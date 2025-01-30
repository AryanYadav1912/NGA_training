
using IntrfacePractice;

namespace INterfaceconcepts
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string ch;
            do
            {
                Console.WriteLine("Enter the Shape: 1.Circle 2.Rectangle");
                string? type = Console.ReadLine();

                switch (type.ToLower())
                {
                    case "circle":
                        Shape ish = new Circle() { radius = 10 };
                        ish.CalculatedArea();
                        break;
                    case "rectangle":
                        Shape rec = new rectangle() { L = 10, B = 5 };
                        rec.CalculatedArea();
                        break;
                    default:
                        Shape sq = new Circle();
                        sq.SquareArea(5);
                        break;
                }
                Console.WriteLine("Do you want to continue (yes/no):");
                ch = Console.ReadLine();
            } while (ch.Equals("yes"));

        }
    }
}