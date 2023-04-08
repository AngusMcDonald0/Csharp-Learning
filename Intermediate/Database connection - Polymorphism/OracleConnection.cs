using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection___Polymorphism
{
    internal class OracleConnection : DbConnection
    {
        public OracleConnection(string oracleConnectionString)
           : base(oracleConnectionString)
        {
            Console.WriteLine("Oracle connection initiated");
        }
        public override void Open()
        {
            if (connected)
                Console.WriteLine("connection already opened");
            else
                Console.WriteLine("oracle connection open");
            connected = true;
        }

        public override void Close()
        {
            if (!connected)
                Console.WriteLine("connection already closed");
            else
                Console.WriteLine("oracle connection closed");
            connected = false;
        }
    }
}
