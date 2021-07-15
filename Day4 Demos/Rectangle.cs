using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Demos
{
    class Rectangle : Shape
    {
        int l, w;
        public override void GetDimensions()
        {
            Console.WriteLine("Enter Value of Lenth");
            l = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of Width");
            w = Byte.Parse(Console.ReadLine());

        }
        public override void CalculateArea()
        {
            area = l * w;
        }
       
    }
}
