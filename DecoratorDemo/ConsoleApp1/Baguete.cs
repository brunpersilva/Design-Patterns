using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Baguete : Bread
    {
        public void Construct()
        {
            Name = "Baguete";
        }

        public double Value()
        {
            return 3.0;
        }
    }
}

