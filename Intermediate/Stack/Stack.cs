using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        private readonly List<object> _stack = new();

        public void Push (object obj) 
        {
            if (obj == null)
            {
                throw new InvalidOperationException();
            }
            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count < 1)
            {
                throw new InvalidOperationException();
            } 
            var index = _stack.Count - 1;
            var obj = _stack[index];
            _stack.RemoveAt(index);
            return obj;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
