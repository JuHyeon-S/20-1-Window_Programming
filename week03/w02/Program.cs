using System;

namespace w02
{
    class Car
    {
        string[,] storage;
        public Car(int x)
        {
            storage = new string[x,3];
            for(int i = 0; i < x; i++)
            {
                Console.Write("차량소유자 : ");
                storage[i,0] = Console.ReadLine();
                Console.Write("차량번호 : ");
                storage[i,1] = Console.ReadLine();
                Console.Write("연락처 : ");
                storage[i,2] = Console.ReadLine();
            }
        }

        public int Size => storage.GetLength(0);

        public string this[int index]
        { 
            get
            {
                if (AvailIndex(index))
                {
                    return "차번호" + storage[index,1] + " = 소유자 : " + storage[index,0] + "  연락처 : " + storage[index,2];
                }
                return string.Empty;
            }
        }
        private bool AvailIndex(int index)
        {
            return (index >= 0) && (index < storage.GetLength(0));
        }

        public string this[string key]
        {
            get
            {
                int find = FindKey(key); 
                if (find == -1) return null;
                return "소유자 : " + storage[find,0] + " 연락처 : " + storage[find,2];
            }
        }
        private int FindKey(string key)
        {
            for(int i = 0; i < storage.GetLength(0); i++)
            {
                if (key == storage[i,1])
                    return i;
            }
            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car md;
            Console.Write(" 저장하고자 하는 데이터 갯수를 입력하세요 >> ");
            md = new Car(int.Parse(Console.ReadLine()));
            Console.WriteLine("____________________");
            Console.WriteLine("\n **** 전체 데이터 리스트 **** ");
            for (int i = 0; i < md.Size; i++)
            {
                Console.WriteLine(i + " ) " + md[i]); //정수를 인자로 받는 인덱서 사용
            }

            Console.Write(" 차량 번호를 입력하세요 >> ");
            string result = md[Console.ReadLine()] ?? "해당 차량이 없습니다";
            Console.WriteLine("____________________");
            Console.WriteLine(result);  //문자열 인자로 받는 인덱서 사용}
        }
    }

}
