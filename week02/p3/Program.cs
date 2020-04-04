using System;

namespace p3
{
    class Program
    {
        static void Main(string[] args)
        {
            var data1 = 34.5f;
            var data2 = 34.56;
            var data3 = 300;
            var data4 = 'a';
            Console.WriteLine(" data1 : {0}   type : {1} ", data1, data1.GetType());
            Console.WriteLine(" data2 : {0}   type : {1} ", data2, data2.GetType());
            Console.WriteLine(" data3 : {0}   type : {1} ", data3, data3.GetType());
            Console.WriteLine(" data4 : {0}   type : {1} ", data4, data4.GetType());

            data1 = 1161;
            Console.WriteLine(" data1 : {0}   type : {1} ", data1, data1.GetType());
        }
    }
}
