using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Demos
{
    class Square : Shape
    {
        int side ;
        public override void GetDimensions()
        {
            Console.WriteLine("Enter Value of side");
            side = Byte.Parse(Console.ReadLine());
        }
        public override void CalculateArea()
        {
            area = side * side;
        }
        
    }
}
