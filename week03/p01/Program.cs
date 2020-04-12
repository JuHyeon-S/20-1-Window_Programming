using System;

namespace p01
{
    class Program
    {
        static void WriteLog(string format, params object[] arg)
        {
            var s = string.Format(format, arg);
            Console.WriteLine(s);
        }
        static public void Main()
        {
            string user = "C#";
            string message = "가변길이 매개변수 활용";
            WriteLog("Time = {0} User = {1}  Message = {2}", 3, user, message);
        }

    }
}
