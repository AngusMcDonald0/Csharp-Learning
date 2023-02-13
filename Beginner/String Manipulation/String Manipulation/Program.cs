using System;
using System.Collections.Generic;


namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Consecutive();
        }

        public static void Consecutive()
        {
            Console.WriteLine("Enter a few - seperated numbers");
            var input = Console.ReadLine();
            var numbers = new List<int>();
            foreach (var num in input.Split("-"))
            {
                numbers.Add(Convert.ToInt32(num));
            }
            bool consecutive = true;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] > numbers[i+1])
                    consecutive = false;
            }
            Console.WriteLine(consecutive ? "Consecutive" : "Non-Consecutive");
        }
    }
}
