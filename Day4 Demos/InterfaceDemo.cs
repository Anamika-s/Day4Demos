using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Demos
{
    interface I1 {
        void Get();
    }
    interface I2
    {
        void Get();
        void Display();
    }

    class C1 : I1, I2
    {
        void I2.Display()
        {
            
        }

        void I1.Get()
        {
            
        }

        void I2.Get()
        {
            
        }
    }
    class InterfaceDemo : I1, I2
    {
        public void Display()
        {
            
        }

        public void Get()
        {
             
        }
    }

}
