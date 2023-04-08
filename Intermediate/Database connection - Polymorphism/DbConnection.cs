using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection___Polymorphism
{
    abstract internal class DbConnection
    {
        private string? _connectionString;
        private TimeSpan _timeout;
        public bool connected;

        public DbConnection(string connectionStr)
        {
            if (string.IsNullOrWhiteSpace(connectionStr))
                throw new ArgumentNullException("A connection string is required");
            _connectionString = connectionStr;
        }

        public abstract void Open();

        public abstract void Close();
    }
}
