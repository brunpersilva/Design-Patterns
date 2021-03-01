using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class French : Bread
    {
        public void Construct()
        {
            Name = "French";
        }

        public double Value()
        {
            return 2.0;
        }
    }
}
