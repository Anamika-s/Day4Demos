using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Demos
{
    class Triangle : Shape
    {
        int basee, height;
        public override void CalculateArea()
        {
            area = 1 / 2 * (basee * height);
        }

        public override void GetDimensions()
        {
            Console.WriteLine("Enter Value of Base");
            basee = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of Height");
            height = Byte.Parse(Console.ReadLine());
        }
    }
}
