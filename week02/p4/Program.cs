using System;

namespace p4
{
    class Program
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 10.5;
            if (num1.HasValue)
                Console.WriteLine("num1= {0}", num1);
            else
                Console.WriteLine("num1 does not have value");
            Console.WriteLine("num2= {0}", num2);

        }
    }
}
