using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" short : {0} ~ {1} ", short.MinValue, short.MaxValue);
            Console.WriteLine(" ushort : {0} ~ {1} ", ushort.MinValue, ushort.MaxValue);
            char data = 'a';
            Console.WriteLine(" data : {0}, data+1 : {1} ", data, (char)(data + 1));
            Console.WriteLine(" double : {0} ~ {1} ", double.MinValue, double.MaxValue);
            Console.WriteLine(" int : {0} ~ {1} ", int.MinValue, int.MaxValue);
            Console.WriteLine(" uint : {0} ~ {1} ", uint.MinValue, uint.MaxValue);
        }
    }
}
