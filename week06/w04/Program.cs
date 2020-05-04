using System;
using System.Collections.Generic;

namespace w04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var d = new Dictionary<string, string>();
            int i;
            string str1, str2;

            while (true)
            {
                Console.WriteLine("1:추가 2:검색 3:출력 4:종료");
                i = int.Parse(Console.ReadLine());
                if(i == 1)
                {
                    Console.Write("축약어 : ");
                    str1 = Console.ReadLine();
                    Console.Write("의미 : ");
                    str2 = Console.ReadLine();
                    d.Add(str1, str2);
                }
                else if(i == 2)
                {
                    Console.Write("축약어 : ");
                    str1 = Console.ReadLine();
                    foreach(string s in d.Keys)
                    {
                        if(str1 == s)
                        {
                            Console.WriteLine("word) {0}. mean) {1}", str1, d[str1]);
                        }
                    }
                }
                else if(i == 3)
                {
                    foreach (string s in d.Keys)
                    {
                        Console.WriteLine("word) {0}. mean) {1}", s, d[s]);                        
                    }
                }
                else if(i == 4)
                {
                    break;
                }
            }
        }
    }
}
