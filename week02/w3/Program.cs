using System;

namespace w3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            int sum = 0;
            int x, y, z;
            while (true)
            {
                sum = 0;
                x = num / 100;
                y = (num - x * 100) / 10;
                z = (num - x * 100 - y * 10);
                sum = (int)(Math.Pow(x,3) + Math.Pow(y, 3) + Math.Pow(z, 3));
                if (num == sum)
                {
                    Console.WriteLine(num);
                }
                num++;
                if (num > 500) break;
            }
        }
    }
}
