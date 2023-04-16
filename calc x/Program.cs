using System;
namespace project
{
    class test
    {
        public static void Main()
        {
            Console.WriteLine("inter a number");
            Double x = Convert.ToDouble(Console.ReadLine());
            double show=calc(x);
            Console.Write(show);
        }
        private static Double calc(Double x)       
        {
            Double Result = Math.Pow(x, 2) + 2 * x - 4;
            return Result;
        }
    }
  }

