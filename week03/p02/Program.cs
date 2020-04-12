using System;

namespace p02
{
    class Person
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Information => $"name = {Name}  number = {Number} ";
    }
    class Program
    {
        static public void Main(string[] args)
        {
            Person person = new Person()
            {
                //초기화 하고자 하는 프로퍼티만 선택가능, 세미콜론이 아닌 콤머로 구분
                Number = 2020,
                Name = "C#"
            };
            Console.WriteLine(person.Information);
        }
    }

}
