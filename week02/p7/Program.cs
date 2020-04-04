using System;
using System.Threading;

namespace p7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 3);
                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else if (x % 3 == 2)
                    Console.WriteLine("^_@");
                Thread.Sleep(500);  //Sleep() : 괄호안의 값만큼 실행 지연, 밀리세컨드 단위
                x++;
            }

        }
    }
}
