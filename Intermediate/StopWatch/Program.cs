using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stopwatch is ready: ");
            var input = Console.ReadLine();

            if (input == "start")
            {
                var stopWatch = new StopWatch();
                stopWatch.startTime = DateTime.Now;
                Console.WriteLine("Hit enter to stop");
                var enter = Console.ReadLine();
                if (enter == "")
                {
                    stopWatch.stopTime = DateTime.Now;
                    var count = stopWatch.TimeElapsed();
                    Console.WriteLine("Time elapsed:" + count);
                }
            }
        }
    }
}