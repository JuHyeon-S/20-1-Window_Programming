using System;

namespace w4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("행 크기를 입력하세요");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("열 크기를 입력하세요");
            y = int.Parse(Console.ReadLine());
            int num = 1;
            int check = 1;
            for (int i = 1; i <= x; i++)
            {
                if (check % 2 == 0)
                {
                    num += (y - 1);
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write("{0,3}", (num--));
                    }
                    num += (y + 1);
                }
                else
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write("{0,3}", (num++));
                    }
                }
                Console.WriteLine();
                check++;
            }
        }
    }
}
