using System;

namespace Control_Flow
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static void Numvalid()
        {
            Console.WriteLine("Enter number between 1 and 10: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num > 0 && num < 11 ? "Valid" : "Invalid");
        }


    }
}
