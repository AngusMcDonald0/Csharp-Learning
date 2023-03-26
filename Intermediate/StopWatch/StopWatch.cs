using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class StopWatch
    {
        public DateTime startTime { get; set; }
        public DateTime stopTime { get; set; }

        public TimeSpan TimeElapsed() 
        {
            var timeElapsed = stopTime - startTime;
            return timeElapsed;
        }
    }
}
