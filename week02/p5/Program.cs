using System;

namespace p5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "하늘";
            string s2 = String.Copy(s1);
            string s3 = String.Concat(s1, s2);
            Console.WriteLine("문자열 복사 : {0}  \n문자열 연결 : {1} ", s2, s3);

            string s4 = " 물: 불: 흙: 나무";
            string[] spstr = s4.Split(':');
            Console.WriteLine("문자열 분리 전 :  " + s4);
            Console.WriteLine("문자열 분리 후 : ");
            for (int i = 0; i < spstr.Length; i++)
            {
                Console.WriteLine(spstr[i]);
            }

            String str = " Blank String Csharp ";
            Console.WriteLine("문자열(길이) = " + str + "(" + str.Length + ")");
            Console.WriteLine("공백 제거(Trim)=" + str.Trim());
            Console.WriteLine("공백 제거후 문자열 길이(Trime)=" + str.Trim().Length);
            Console.WriteLine("왼쪽 공백 제거(TrimStart)= " + str.TrimStart());
            Console.WriteLine("왼쪽 공백 제거 후 문자열 길이(TrimStart) = " + str.TrimStart().Length);
            Console.WriteLine("오른쪽 공백 제거(TrimEnd)=" + str.TrimEnd());
            Console.WriteLine("오른쪽 공 백 제거 후 문자열 길이(TrimEnd) = " + str.TrimEnd().Length);
            Console.WriteLine("대문자 변환(ToUpper) = " + str.ToUpper());
            Console.WriteLine("문자열 치환(Replace) = " + str.Replace('s', 't'));
            Console.WriteLine("문자열 검색(IndexOf) = " + str.IndexOf("S"));
            Console.WriteLine("문자열 추출(Substring)=" + str.Substring(2, 3));
            Console.WriteLine("문자열 삽입(Insert)=" + str.Insert(2, "fun"));
            Console.WriteLine("문자열 지우기(Remove)=" + str.Remove(2, 3));

        }
    }
}
