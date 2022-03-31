using System;
using System.Collections.Generic;
using System.Text;

namespace task123.Models1
{
    class CapacityLimitException : Exception
    {
        public CapacityLimitException(string message) : base(message)
        {

        }
    }
}
