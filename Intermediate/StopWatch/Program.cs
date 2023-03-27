using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            while (input != "exit")
            {
                var stopWatch = new StopWatch();
                Console.WriteLine("------StopWatch------");
                Console.WriteLine("Press enter to start");
                Console.ReadLine();
                stopWatch.Start();
                Console.WriteLine("Press enter to stop");
                Console.ReadLine();
                stopWatch.Stop();
                Console.WriteLine("Time elapsed:" + stopWatch.TimeElapsed() + "\nType exit to quit or press enter to go again");
                input = Console.ReadLine();
            }
        }
    }
}