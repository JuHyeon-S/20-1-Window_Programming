using System;

namespace w02
{
    class Date
    {
        private int day, month, year;
        private static int m;
        public Date(int mm, int dd, int yy)
        {     // 생성자
            day = dd;
            month = mm;
            year = yy;
        }
        public static Date operator +(Date d, int n)
        {// 날짜에 대한 + 연산 정의
            m = DateTime.DaysInMonth(d.year, d.month);
            if ((d.day += n) > m)
            {
                if (d.month == 12)
                {
                    d.month = 0;
                    d.year++;
                }
                d.month++;
                d.day -= m;
            }
            return d;
        }

        public static Date operator -(Date d, int n)
        { // 날짜에 대한 - 연산 정의
            if ((d.day -= n) <= 0)
            { 
                while (true)                            
                {
                    m = DateTime.DaysInMonth(d.year, d.month);
                    if (d.month == 1)
                    {
                        d.month = 13;
                        d.year--;
                    }
                    d.month--;
                    if ((d.day >0) && ((m - d.day) > 0))
                    {
                        d.day = m - d.day;
                        break;
                    }
                    else
                    {
                        if(d.day < 0)
                        {
                            d.day += m;
                        }
                        else if (d.day == 0)
                        {
                            d.day = m;
                        }
                    }
                }
            }
            
            return d;
        }
        override public string ToString()
        {  // mm/dd/yy
            return string.Format("{0,2}/{1,2}/{2,2}", month, day, year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(4, 20, 2020);  //날짜는 자유롭게 본인이 정할 것
            Date d2 = new Date(8, 20, 1999);

            Console.WriteLine($"d1 = {d1}");
            Console.WriteLine($"d2 = {d2}");

            d2 = d2 + 40;  // 바꾸기
            Console.WriteLine("d2+40 : " + d2);
            d1 = d1 - 10;  	// 바꾸기
            Console.WriteLine("d1-10 : " + d1);
        }
    }

}
