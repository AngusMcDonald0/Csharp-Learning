using System;
using System.Collections.Generic;


namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Vowels();
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

        public static void Valid()
        {
            Console.WriteLine("Enter a time: ");
            var input = Console.ReadLine();
            if (TimeSpan.TryParse(input, out var result))
                Console.WriteLine("passed");
            else
                Console.WriteLine("failed");
        }

        public static void PascalCase()
        {
            Console.WriteLine("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var words = input.Split(" ");
            var capitalizedText = "";
            foreach (var word in words)
            {
                var capitalizedWord = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                capitalizedText += capitalizedWord;
            }
            Console.WriteLine(capitalizedText);
        }

        public static void Vowels()
        {
            Console.WriteLine("Enter a word: ");
            var input = Console.ReadLine();
            var vowels = new List<char>{ 'a', 'e', 'i', 'o', 'u' };
            var count = 0;
            foreach (var letter in input)
            {
                if (vowels.Contains(letter))
                    count ++;
            }
            Console.WriteLine(count);
        }
    }
}
