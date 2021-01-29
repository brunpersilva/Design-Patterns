using System;
using System.Collections.Generic;
using System.Text;

namespace AdaperConsole
{
    class MysqlAdapter : ISqlAcess
    {
        private MysqlAcess _mysqlAcess { get; set; }

        public MysqlAdapter(MysqlAcess mysqlAcess)
        {
            _mysqlAcess = mysqlAcess;
        }

        public void Insert()
        {
            _mysqlAcess.InsertMysql();
        }

        public void Update()
        {
            _mysqlAcess.UpdateMysql();
        }

        public void Delete()
        {
            _mysqlAcess.DeleteMysql();
        }

        
    }
}
