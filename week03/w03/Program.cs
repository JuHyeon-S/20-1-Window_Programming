using System;

namespace w03
{
    class Person  //Person 클래스에 대한  생성자 없음
    {
        //비밀번호와 아이디에 대한 프로퍼티 정의 – 본인작성
        public int Pass { get; set; }
        public string Id { get; set; }
    }

    class PersonManage
    {
        Person[] people;
        int index = 0;
        Random rnd;

        //크기가 50인 Person 배열 객체 생성하고 난수를 위한 객체를 생성하는 생성자 – 본인 작성
        public PersonManage()
        {
            people = new Person[50];
            rnd = new Random();
        }
        //아이디를 입력받으며 비밀번호는 1부터 100사이의 난수를 생성하여 저장 하는 메소드 – 본인작성
        public void Save()
        {
            Console.Write("아이디를 입력하세요 >> ");
            string a = Console.ReadLine();
            int b = rnd.Next() % 100 + 1;
            people[index] = new Person() { Id = a, Pass = b };
            index++;
        }
        //문자열 id를 매개변수로 받아 id에 해당하는 비밀번호를 반환하는 인덱서 – 본인작성
        public int this[string id] { 
            get { return getId(id); }
        }

        //매개변수로 받은 문자열 id와 일치하는 비밀번호 반환, 없으면 0을 반환하는 메소드 – 본인작성
        private int getId(string tId)
        {
            int? value = null;
            for (int i = 0; i < index; i++)
            {
                if (tId == people[i].Id)
                {
                    value = people[i].Pass;
                    break;
                }
            }
            return value ?? 0;
        }
        //배열에 저장된 모든 내용을 출력하는 메소드 – 본인작성
        public new void ToString()
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine("id = {0} pass = {1}", people[i].Id, people[i].Pass);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // PersonManage 객체를 생성하고 제시된 결과처럼 입력된 메뉴를 처리 – 본인작성
            PersonManage pM = new PersonManage();

            char select;
            string search;

            while (true)
            {
                Console.Write("1:저장, 2:검색, 3:출력, 종료하려면 s를 입력하세요 : ");
                select = (char)Console.Read();
                Console.ReadLine();
                if (select == 's')
                {
                    break;
                }
                else if (select == '1')
                {
                    pM.Save();
                }
                else if (select == '2')
                {
                    Console.Write("검색하고자 하는 id >>> ");
                    search = Console.ReadLine();
                    Console.WriteLine("비밀번호 : "+ pM[search]);
                }
                else if (select == '3')
                {
                    pM.ToString();
                }
            }
        }
    }
}
