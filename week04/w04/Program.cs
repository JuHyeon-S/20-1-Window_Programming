using System;

namespace w04
{
    class Person
    {
        string name;
        int[] birth = new int[3];
        int age;

        public Person(string n, int []b, int a)
        {
            name = n;
            for(int i = 0; i < birth.Length; i++)
            {
                birth[i] = b[i];
            }
            age = a;
        }

        public int getBirthY()
        {
            return birth[0];
        }
        public virtual void display()
        {
            Console.WriteLine("이름 : {0}\t나이 : {1}", name, age);
            Console.WriteLine("생년월일 : {0}년 {1}월 {2}일", birth[0], birth[1], birth[2]);
        }
    }

    class Student : Person
    {
        int score;
        char grade;

        public Student(int sc, string n, int []b, int a) : base(n, b, a) { score = sc; }
        public char getGrade()
        {
            if (score >= 90) grade = 'A';
            else if (score >= 80) grade = 'B';
            else if (score >= 70) grade = 'C';
            else if (score >= 60) grade = 'D';
            else grade = 'F';
            
            return grade;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("점수 : {0}\t학점 : {1}", score, getGrade());
        }
    }

    class Employee : Person
    {
        int empnum;
        string dept;
        
        public Employee(int e, string d, string n, int []b, int a) : base(n, b, a)
        {
            empnum = e;
            dept = d;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("사번 : {0}\t부서 : {1}", empnum, dept);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] obj;
            int check = 0;
            Console.Write("생성하고자 하는 객체 수를 입력하세요 : ");
            check = int.Parse(Console.ReadLine());

            obj = new Person[check];

            int count = 0;
            int ch;
            string name, dept;
            int age, empnum, score;
            int[] birth = new int[3];
            do
            {
                Console.Write("1. Student 생성   2. Employee 생성 ==> ");
                ch = int.Parse(Console.ReadLine());
                Console.Write("{0})이름 => ", count + 1);
                name = Console.ReadLine();
                Console.WriteLine("생년월일");
                for (int i = 0; i < 3; i++)
                {
                    birth[i] = int.Parse(Console.ReadLine());
                }
                age = DateTime.Today.Year - birth[0];
                if (ch == 1)
                {
                    Console.Write("점수=>");
                    score = int.Parse(Console.ReadLine());

                    obj[count] = new Student(score, name, birth, age);
                }

                else if (ch == 2)
                {
                    Console.Write("사번=>");
                    empnum = int.Parse(Console.ReadLine());
                    Console.Write("부서=>");
                    dept = Console.ReadLine();

                    obj[count] = new Employee(empnum, dept, name, birth, age);
                }
                count++;
            } while (count < check);

            int b, yy;

            for (int i = 0; i < obj.Length; i++)
            {
                Console.WriteLine("==========================================");

                obj[i].display();
                b = (((obj[i].getBirthY() % 1000) % 100) % 10);
                yy = (((DateTime.Today.Year % 1000) % 100) % 10);

                if (b > 5) { b = b - 5; }
                if (b == 0) { b += 5; }
                if (yy > 5) { yy -= 5; }

                Console.WriteLine("\n\n>>>  공적 마스크 구매 가능 여부 <<<");
                
                if (b == yy)
                {
                    Console.WriteLine(">>> 마스크 구매가 가능합니다.\n"); 
                }
                else
                {
                    Console.WriteLine(">>> 해당요일이 아닙니다.");
                    Console.WriteLine(">>> 오늘은 {0}입니다.", DateTime.Today.DayOfWeek);
                    Console.WriteLine(">>> {0}에 구매 가능합니다.\n", DayOfWeek.Sunday+b);
                }
            }
        }
    }
}
