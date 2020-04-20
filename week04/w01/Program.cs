using System;

namespace w01
{
    delegate void DelegateOne(int x);
    delegate void DelegateTwo(int x, int y);
    class MyClass
    {
        public void MUL(int x)
        {
            Console.WriteLine("MUL = {0}", x * x);
        }
        public void ADD(int x, int y)
        {
            Console.WriteLine("ADD = {0}", x + y);
        }
        public static void SUB(int x, int y)
        {
            Console.WriteLine("SUB = {0}", x - y);
        }
    }

    class MyClassTest
    {
        static void Main(string[] args)
        {
            Random rn = new Random();
            int r;

            MyClass obj = new MyClass();
            DelegateOne d1 = new DelegateOne(obj.MUL);
            DelegateTwo d2 = new DelegateTwo(obj.ADD);
            DelegateTwo d3 = new DelegateTwo(MyClass.SUB);

            int x, y;

            for (int i = 0; i < 5; i++)
            {
                r = rn.Next(1, 20);
                Console.WriteLine("random number : {0}", r);
                if (r / 10 < 1) { d1(r); }
                else
                {
                    x = r / 10;
                    y = r % 10;
                    d2(x, y);
                    d3(x, y);
                }
            }
        }
    }
}
