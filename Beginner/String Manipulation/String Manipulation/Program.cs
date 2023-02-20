using System;
using System.Collections.Generic;


namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Duplicate();
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

        public static void Duplicate()
        {
            Console.WriteLine("Enter a few - seperated numbers");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
                return;
            var numbers = new List<int>();
            foreach (var num in input.Split("-"))
            {
                numbers.Add(Convert.ToInt32(num));
            }
            var uniques = new List<int>();
            foreach (var num in numbers)
            {
                if (uniques.Contains(num))
                {
                    Console.WriteLine("Duplicate");
                    break;
                }
                else
                {
                    uniques.Add(num);
                }
            }
        }
    }
}
