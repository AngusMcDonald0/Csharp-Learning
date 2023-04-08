namespace Database_connection___Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracleConnection = new OracleConnection("12345");
            var sqlConnection = new SqlConnection("54321");
            oracleConnection.Open();
            sqlConnection.Open();
            sqlConnection.Open();
            sqlConnection.Close();
        }
    }
}