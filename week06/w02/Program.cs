using System;

namespace w02
{
    interface IOperation<T>
    {
        void Insert(T str);  //매개변수로 받은 str을 스택에 삽입(push)
        T Delete();  //스택 탑 원소 제거(pop) 후 반환
        bool Search(T str); //매개변수로 받은 str 원소의 존재 여부 반환
        T GetCurrentElt();  //현재 스택 탑에 있는 원소 반환
        int NumOfElements();  //스택에 존재하는 원소 개수 반환
        void PrintStack();  //스택에 저장된 모든 원소 출력
    }

    class Stack<T> : IOperation<T>
    {
        private T[] arr;
        int count = 0;
        public Stack(int len)
        {
            arr = new T[len];
            count = 0;
        }
        public void Insert(T str)
        {   //매개변수로 받은 str을 스택에 삽입(push)
            arr[count++] = str;
        }
        public T Delete()
        {   //스택 탑 원소 제거(pop) 후 반환
            T str = arr[count - 1];
            arr[count - 1] = default(T);
            count--;
            return str;
        }
        public bool Search(T str)
        {   //매개변수로 받은 str 원소의 존재 여부 반환
            foreach(var x in arr)
            {
                if (x.Equals(str)) return true;
            }
            return false;
        }

        public T GetCurrentElt()
        {   //현재 스택 탑에 있는 원소 반환
            return arr[count - 1];
        }

        public int NumOfElements()
        {  //스택에 존재하는 원소 개수 반환
            return count;
        }
        public void PrintStack()
        {  //스택에 저장된 모든 원소 출력
            for (int i =0;i < count; i++)
            {
                Console.Write("{0}", arr[i]);
                if (i == (count - 1))
                {
                    Console.WriteLine();
                    break;
                }
                Console.Write(" => ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 스택 테스트
            Stack<string> stack = new Stack<string>(100);
            Stack<double> stack1 = new Stack<double>(3);

            string str;
            for(int i = 0; i < 3; i++)
            {
                Console.Write("삽입 : ");
                str = Console.ReadLine();
                stack.Insert(str);
            }

            Console.WriteLine("\n======== Stack Test =========");
            Console.WriteLine(">>>스택에 저장된 문자열 출력 :");
            stack.PrintStack();
            Console.WriteLine(">>>스택 탑 원소 제거 :\t{0}", stack.Delete());
            Console.WriteLine(">>>스택에 저장된 문자열 String A 찾기 :\t{0}", stack.Search("String A"));
            Console.WriteLine(">>>스택 탑에 있는 원소 출력 :\t{0}", stack.GetCurrentElt());
            Console.WriteLine(">>>스택에 저장된 원소 개수 :\t{0}", stack.NumOfElements());

            Console.WriteLine('\n');

            double d;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("삽입 : ");
                d = Double.Parse(Console.ReadLine());
                stack1.Insert(d);
            }

            Console.WriteLine("\n======== Stack Test =========");
            Console.WriteLine(">>>스택에 저장된 실수 출력 :");
            stack1.PrintStack();
            Console.WriteLine(">>>스택 탑 원소 제거 :\t{0}", stack1.Delete());
            Console.WriteLine(">>>53.5 찾기 :\t{0}", stack1.Search(53.5));
            Console.WriteLine(">>>스택 탑에 있는 원소 출력 :\t{0}", stack1.GetCurrentElt());
            Console.WriteLine(">>>스택에 저장된 원소 개수 :\t{0}", stack1.NumOfElements());
        }
    }
}