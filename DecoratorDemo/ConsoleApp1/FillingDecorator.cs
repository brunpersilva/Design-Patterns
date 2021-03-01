using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class FillingDecorator
    {
        protected string Name;

        public string GetName()
        {
            return Name;
        }
    }
}
