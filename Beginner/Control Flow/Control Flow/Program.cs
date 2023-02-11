using System;

namespace Control_Flow
{
    public class Program
    {
        static void Main(string[] args)
        {
            Max();
        }

        public static void Numvalid()
        {
            Console.WriteLine("Enter number between 1 and 10: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num > 0 && num < 11 ? "Valid" : "Invalid");
        }

        public static void Divide()
        {
            int counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) counter ++;
            }
            Console.WriteLine(counter);
        }

        public static void Add()
        {
            var input = "";
            var total = 0;
            while(true)
             {
                Console.WriteLine("Enter a number:");
                input = Console.ReadLine();

                if (input == "ok") break;

                total += Convert.ToInt32(input);
            }
            Console.WriteLine(total);
        }

        public static void Factorial()
        {
            Console.WriteLine("Enter Number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var total = 1;
            for (var i = input; i > 0; i--)
            {
                total *= i;
            }
            Console.WriteLine("{0}! = {1}", input, total);
        }

        public static void Random()
        {
            var num = new Random().Next(1, 10);
            Console.WriteLine("Hint, the number is {0}", num);
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess a number between 1 and 10:");
                if (Convert.ToInt32(Console.ReadLine()) == num)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You lost");
        }

        public static void Max()
        {
            Console.WriteLine("Enter comma seperated numbers (x, x, x, ...):");
            var input = Console.ReadLine();
            var numbers = input.Split(",");
            var max = Convert.ToInt32(numbers[0]);
            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max) max = number;
            }
            Console.WriteLine("Highest number: " + max);
        }

    }
}
