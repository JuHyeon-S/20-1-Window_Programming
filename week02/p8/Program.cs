using System;

namespace p8
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 48529;
            decimal dis = 84344.565m;
            var s1 = String.Format("1)digit ={0, 10:#,0} \n2)dis = {1,10:0.00}", digit, dis); //Format() 사용
            var s2 = String.Format("3)digit ={0, 10} \n4)dis = {1,10}", digit, dis);
            var s3 = $"5){digit,-10:#,0}";  //문자열 보간
            var s4 = $"6){dis,10:0.00}";
            var s5 = "7)" + dis.ToString("0.00"); //ToString() 사용

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);

        }
    }
}
