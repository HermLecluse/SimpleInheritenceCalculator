using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        private int a, b;
        private Context context = new Context();
        static void Main(string[] args)
        {
            Program calculator = new Program();
            Console.WriteLine("Please enter the first number");
            calculator.a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            calculator.b =Convert.ToInt32(Console.ReadLine());
            try
            {
                calculator.Calculate(calculator.a, calculator.b);
            }
            catch (OpperationNotSupportedException onsException)
            {
                Console.WriteLine(onsException.Message);
                calculator.Calculate(calculator.a, calculator.b);
            }
            catch (DivideByZeroException dbzException)
            {
                Console.WriteLine(dbzException.Message);
                calculator.Calculate(calculator.a, calculator.b);

            }
        }

        private void Calculate(int a, int b)
        {
            Console.WriteLine("Choose opperator : +, -, *, /,");
            var temp = Console.ReadLine();
            Console.WriteLine(context.SetStrategy(temp).Calculate(a, b));
        }
    }
}
