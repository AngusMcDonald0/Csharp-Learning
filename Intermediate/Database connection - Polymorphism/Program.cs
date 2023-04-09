namespace Database_connection___Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracleConnection = new OracleConnection("12345");
            var command1 = new DbCommand(oracleConnection, "join a table with an oracle connection please");
            command1.Execute();

            var sqlConnection = new SqlConnection("54321");
            var command2 = new DbCommand(sqlConnection, "join a table but in sql please");
            command2.Execute();
        }
    }
}