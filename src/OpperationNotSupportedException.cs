using System;

namespace Calculator
{
    internal class OpperationNotSupportedException : Exception
    {
        public OpperationNotSupportedException()
        {
        }

        public OpperationNotSupportedException(string message)
            : base(message)
        {
        }

        public OpperationNotSupportedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}