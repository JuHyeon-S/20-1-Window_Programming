using System;

namespace w2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1부터 500 사이의 완전수를 출력합니다.");
            int start = 1;
            int num = 2;
            int sum = 0;
            while (true)
            {
                sum = 0;
                for(int i = 1; i < num; i++)
                {
                    if (num % i == 0) sum += i;
                }
                if (sum == num)
                {
                    Console.WriteLine("\t" + start++ + ") " + num);
                }
                num++;
                if (num > 500) break;
            }
        }
    }
}
