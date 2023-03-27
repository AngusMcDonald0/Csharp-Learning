using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime; 
        private bool _running;

        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("Stopwatch already running");
            }
            _startTime = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            if (!_running) 
            {
                throw new InvalidOperationException("Stopwatch not running");
            }
            _stopTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan TimeElapsed() 
        {
            return _stopTime - _startTime;
        }
    }
}
