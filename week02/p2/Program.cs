using System;

namespace p2
{
    class Program
    {
        enum Suit { Clubs, Hearts, Diamonds, Spades };
        enum Color { Red, Green, Blue };
        //열거형, 각 멤버의 순서 값은 0부터 시작, 1씩 증가
        //특정 순서 값을 원하면 열거형 정의할 때 지정
        // enum Suit {Clubs=3, Hearts, Diamonds, Spades}  

        static void Main(string[] args)
        {

            Color c = Color.Red;
            int j = (int)++c;
            Console.WriteLine("Color = " + (Color)j);

            Suit trumps = Suit.Hearts;
            int i = (int)trumps; //순서값으로 변환, cast 연산
            Console.WriteLine("Cardinality of " + trumps + "=" + i);
            Console.WriteLine("Cardinality of " + (++trumps) + "=" + (i + 1));

        }
    }
}
