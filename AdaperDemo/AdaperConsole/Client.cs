using System;

namespace AdaperConsole
{
    class Client
    {
        static void Main(string[] args)
        {
            SqlCommands oracle = new SqlCommands();

            oracle.Delete();

            MysqlAdapter mysql = new MysqlAdapter(new MysqlAcess());

            mysql.Delete();
            mysql.Update();
            mysql.Insert();
        }
    }
}
