using System;

namespace Calculator
{
    public class Divide : IOpperator
    {
        public int Calculate(int a, int b)
        {
            if (b != 0)
            {
                return a/b;
            }
            throw new DivideByZeroException("Zero is not a valid number, Please enter a valid divider!");
        }
    }
}