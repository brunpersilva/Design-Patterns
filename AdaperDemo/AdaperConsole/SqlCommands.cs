using System;
using System.Collections.Generic;
using System.Text;

namespace AdaperConsole
{
    class SqlCommands : ISqlAcess
    {
        public void Delete()
        {
            Console.WriteLine("SQL Delete");
        }

        public void Insert()
        {
            Console.WriteLine("SQL Insert");
        }

        public void Update()
        {
            Console.WriteLine("SQL Update");
        }
    }
}
