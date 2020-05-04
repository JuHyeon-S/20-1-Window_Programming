using System;

namespace w01
{
    class Program
    {
        static int Search<T>(T []arr, T x)
        {
            int cnt = 0;
            foreach(var n in arr)
            {
                if (n.Equals(x)) cnt++;
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            var array = new int[] { 5, 2, 6, 3, 6, 8, 2, 1, 6, 4 };                 //정수 6의 개수
            var str = new string[] { "사과", "포도", "사과", "토마토", "천혜향" };  //문자열 “사과” 개수

            Console.WriteLine("array : cnt = {0}",Search<int>(array, 6));
            Console.WriteLine("str : cnt = {0}", Search<string>(str, "사과"));
        }
    }
}
