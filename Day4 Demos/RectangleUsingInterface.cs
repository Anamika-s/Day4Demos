using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Rectangle : IShape
    {
        int l, w, area;
        public void CalculateArea()
        {
            area = l * w;
        }

        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }

        public void GetDimensions()
        {
            Console.WriteLine("Enter Value of Lenth");
            l = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of Width");
            w = Byte.Parse(Console.ReadLine());
        }
    }
}
