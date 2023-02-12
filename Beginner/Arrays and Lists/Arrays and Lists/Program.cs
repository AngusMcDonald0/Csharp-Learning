using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse();
        }

        public static void Likes()
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Who liked you post?");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input)) break;
                names.Add(input);
            }
            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others liked your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} liked your post", names[0], names[1]);
            else
                Console.WriteLine("{0} liked your post", names[0]);
        }

        public static void Reverse()
        {

        }
    }
}
