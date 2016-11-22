using System;

namespace Calculator
{
    class Program
    {
        private int _a, _b;
        private readonly Context _context = new Context();
        static void Main(string[] args)
        {
            Program calculator = new Program();
            Console.WriteLine("Please enter the first number");
            calculator._a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            calculator._b =Convert.ToInt32(Console.ReadLine());
            try
            {
                calculator.Calculate(calculator._a, calculator._b);
            }
            catch (OpperationNotSupportedException onsException)
            {
                Console.WriteLine(onsException.Message);
                calculator.Calculate(calculator._a, calculator._b);
            }
            catch (DivideByZeroException dbzException)
            {
                Console.WriteLine(dbzException.Message);
                calculator.Calculate(calculator._a, calculator._b);

            }
        }

        private void Calculate(int a, int b)
        {
            Console.WriteLine("Choose opperator : +, -, *, /,");
            var temp = Console.ReadLine();
            Console.WriteLine(_context.SetStrategy(temp).Calculate(a, b));
        }
    }
}
