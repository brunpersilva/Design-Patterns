using System;
using System.Collections.Generic;
using System.Text;

namespace AdaperConsole
{
    interface ISqlAcess
    {
        public void Insert();
        public void Update();
        public void Delete();
    }
}
