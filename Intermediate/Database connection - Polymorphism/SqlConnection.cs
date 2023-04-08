using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection___Polymorphism
{
    internal class SqlConnection : DbConnection
    {
        public SqlConnection(string sqlConnectionString)
            : base(sqlConnectionString)
        {
            Console.WriteLine("Sql connection initiated");
        }
        public override void Open()
        {
            if (connected)
                Console.WriteLine("connection already opened");
            else
                Console.WriteLine("sql connection open");
                connected = true;
        }

        public override void Close() 
        {
            if (!connected)
                Console.WriteLine("connection already closed");
            else
                Console.WriteLine("sql connection closed");
                connected = false;
        }
    }
}
