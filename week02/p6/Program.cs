using System;

namespace p6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = new int[] { 3, 5, 22, 65, 2, 60 };
            int? length = dim?.Length;  // (1) dim이 null 이면 null 반환, 그렇지 않으면 멤버 Length 반환
            string str = null;
            Console.WriteLine("Length : " + length);
            Console.WriteLine("첫번째 원소 : " + dim?[0]); //dim이 null이 아니면 [0]반환
            Console.WriteLine("세번째 원소 : " + dim?[2]);
            Console.WriteLine("str : {0} ", str ?? "default");  //str이 null이면 “default”반환
            Console.WriteLine("length : {0} ", length ?? 0);  //length가 null이 아니면 length 반환
        }
    }
}
