using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Sqauare : IShape
    {
        int side, area;
        public void CalculateArea()
        {
            area = side * side;
        }

        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }

        public void GetDimensions()
        {
            Console.WriteLine("Enter Value of side");
            side = Byte.Parse(Console.ReadLine());
        }
    }
}
