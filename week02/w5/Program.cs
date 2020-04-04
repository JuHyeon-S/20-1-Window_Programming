using System;
using System.Threading;

namespace w5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: 보온(60분)\t2: 차(5분)\t3: 중탕(10분)\t4: 급속가열(30분)");
            Console.Write("선택 >>> ");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.Write("@");
                    Thread.Sleep(250);
                }
                Console.WriteLine("\n60(분) 가열 종료");
            }
            else if (choice == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("@");
                    Thread.Sleep(250);
                }
                Console.WriteLine("\n5(분) 가열 종료");
            }
            else if (choice == 3)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("@");
                    Thread.Sleep(250);
                }
                Console.WriteLine("\n10(분) 가열 종료");
            }
            else if (choice == 4)
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.Write("@");
                    Thread.Sleep(250);
                }
                Console.WriteLine("\n30(분) 가열 종료");
            }
            else { Console.WriteLine("잘못입력하였습니다."); }
        }
    }
}
