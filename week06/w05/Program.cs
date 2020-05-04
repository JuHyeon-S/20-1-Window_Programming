using System;
using System.Collections.Generic;
using System.Linq;

namespace w05
{
    public class Member
    {
        //필드구성 – 이름, 아이디, 가입년도, 가입 월
        //생성자 : 이름과 아이디를 매개변수로 받아서 필드초기화, 단, 가입년도와 가입월은 DateTime 사용 
        string name;
        string ID;
        int year;
        int month;

        public Member(string n, string i)
        {
            name = n;
            ID = i;
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
        }
        public string Name {
            get { return name; }
            set { } 
        }
        public string gID {
            get { return ID; }
            set { }
        }
        public override string ToString()
        {
            return "Customer [name=" + name + ", id=" + ID + ", year=" + year + ", month=" + month + "]";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new List<Member>();

            string str1, str2;
            int n;

            while (true)
            {
                Console.Write("1:회원가입 2:회원탈퇴 3:종료 >> ");
                n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.Write("> 이름을 입력하세요 : ");
                    str1 = Console.ReadLine();
                    Console.Write("> 아이디를 입력하세요 : ");
                    str2 = Console.ReadLine();
                    customer.Add(new Member(str1, str2));
                }
                else if(n == 2)
                {
                    Console.Write("> 아이디를 입력하세요 : ");
                    str1 = Console.ReadLine();
                    if (customer.Any(x => x.gID == str1))
                    {
                        customer.Remove(customer.Find(x => x.gID == str1));
                        foreach(var a in customer)
                        {
                            Console.WriteLine(a.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("해당 아이디가 없습니다.");
                    }
                }
                else if(n == 3)
                {
                    Console.WriteLine("프로그램을 종료합니다");
                    break;
                }
            }
        }
    }
}
