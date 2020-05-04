using System;

namespace p02
{
    internal delegate bool judgement(int value);

    class LamdaExam
    {
        Func<int, bool> judge = (x) => x % 2 == 0;
        public int Count(int[] num, Func<int, bool> judge)
        {
            int count = 0;

            foreach (var n in num)
            {
                if (judge(n) == true)
                    count++;
            }
            return count;
        }

        public void Do()
        {
            var array = new int[] { 5, 2, 6, 3, 12, 8, 0, 1, 10, 4 };
            var cnt = Count(array, n => n % 2 == 0); //(2)
            Console.WriteLine($"cnt = {cnt}");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            LamdaExam lamda = new LamdaExam();
            lamda.Do();
        }
    }

}
