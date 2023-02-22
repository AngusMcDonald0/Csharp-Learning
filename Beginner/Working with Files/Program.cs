using System;
using System.IO;

namespace Working_with_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestWord();
        }

        static void Count()
        {
            var path = @"C:\Users\angus\source\repos\Csharp-Learning\Beginner\Working with Files\text file.txt";
            var text = File.ReadAllText(path);
            var words = text.Split(" ");
            Console.WriteLine(words.Length);
        }

        static void LongestWord()
        {
            var path = @"C:\Users\angus\source\repos\Csharp-Learning\Beginner\Working with Files\text file.txt";
            var text = File.ReadAllText(path);
            var words = text.Split(" ");
            var longestWord = "";
            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }
            Console.WriteLine(longestWord);
        }
    }
}
