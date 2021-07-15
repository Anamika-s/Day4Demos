using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Demos
{
   abstract class Shape
    {
        protected int area;
        abstract public void GetDimensions();
        abstract public void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }

    }
}
