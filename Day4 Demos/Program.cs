using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square");
            Square square = new Square();
            square.GetDimensions();
            square.CalculateArea();
            square.DisplayArea();

            Console.WriteLine("Rectangle");
            Rectangle rectangle = new Rectangle();
            rectangle.GetDimensions();
            rectangle.CalculateArea();
            rectangle.DisplayArea();
        }
    }
}
