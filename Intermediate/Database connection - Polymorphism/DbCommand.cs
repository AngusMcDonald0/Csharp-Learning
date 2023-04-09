using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection___Polymorphism
{
    internal class DbCommand
    {
        private DbConnection _dbConnection;
        private string? _dbCommand;
        
        public DbCommand(DbConnection dbConnection, string dbCommand)
        {
            if (dbConnection == null)
                throw new ArgumentNullException("A connection is required");
            
            if (string.IsNullOrWhiteSpace(dbCommand)) 
                throw new ArgumentNullException("A database command is required");
            
            _dbConnection = dbConnection;
            _dbCommand = dbCommand;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine(_dbCommand);
            _dbConnection.Close();
        }
    }
}
