using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Framework
    {
        private string _name;
        private string _db;
        private string _dbUSer;
        private string _dbPassword;
        private string _dbHost;
        private bool _tests;
        private bool _webPack;
        private bool _full;

        public Framework(string name,
                         string db,
                         string dbUSer,
                         string dbPassword,
                         string dbHost,
                         bool tests,
                         bool webPack,
                         bool full)
        {
            _name = name;
            _db = db;
            _dbUSer = dbUSer;
            _dbPassword = dbPassword;
            _dbHost = dbHost;
            _tests = tests;
            _webPack = webPack;
            _full = full;
        }
        public void Run()
        {
            Console.WriteLine("Running");
        }
    }
}
