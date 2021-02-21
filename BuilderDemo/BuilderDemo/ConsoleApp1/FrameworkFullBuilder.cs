using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class FrameworkFullBuilder : IFrameworkFullBuilder
    {
        private readonly Framework _framework;
        public FrameworkFullBuilder()
        {
            _framework = new Framework(name: "teste", db: "mysql", dbUSer: "root", dbPassword: "root", dbHost: "localhost", tests: true, webPack: true, full: true);
        }

        public Framework GetFramework()
        {
            return _framework;
        }
    }
}
