using System.Linq;

namespace Calculator
{
    internal class Context
    {
        public IOpperator SetStrategy(string temp)
        {
            if (temp.Contains('+') ||temp.ToLower().Contains("add"))
            {
                return new Add();
            }
            if (temp.Contains('-') || temp.ToLower().Contains("subtract"))
            {
                return new Subtract();
            }
            if (temp.Contains('/') || temp.ToLower().Contains("divide"))
            {
                return new Divide();
            }
            if (temp.Contains('*') || temp.ToLower().Contains("multiply"))
            {
                return new Multiply();
            }
            throw new OpperationNotSupportedException("Please enter a valid operator");
        }
    }
}