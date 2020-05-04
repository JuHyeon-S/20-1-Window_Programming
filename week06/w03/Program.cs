using System;
using System.Threading;

namespace w03
{
    class Program
    {
        static void ThreadA()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Apple is activated => {0}", (char)('A' + i));
                Thread.Sleep(100);
            }
        }
        static void ThreadB()
        {
            for (int i = 10; i <= 20; i++)
            {
                Console.WriteLine("Orange is activated => {0}", i);
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart ta = new ThreadStart(ThreadA);
            ThreadStart tb = new ThreadStart(ThreadB);

            Thread tha = new Thread(ta);
            Thread thb = new Thread(tb);
            tha.Start();
            thb.Start();
        }
    }
}
