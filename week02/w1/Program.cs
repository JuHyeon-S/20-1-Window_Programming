using System;

namespace w1
{
    class Program
    {
        enum Week {Mon, Tue, Wed, Thu, Fri, Sat, Sun}
        static void Main(string[] args)
        {
            Week day = Week.Thu;
            Console.WriteLine("오늘은 " + day + " 일 입니다");
            Console.WriteLine("어제는 " + (day-1) + " 일 이었고");
            Console.WriteLine("내일은 " + (day+1) + " 일 입니다");
        }
    }
}
