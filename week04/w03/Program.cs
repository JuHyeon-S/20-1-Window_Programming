using System;

namespace w03
{
    interface Figure
    {
        void Area(); //넓이를 구하는 메소드
        void Girth(); //둘레를 구하는 메소드
        void Draw(); //도형을 그리는 메소드
    }

    class Square : Figure
    {
        private int width, height;
        public Square(int w, int h)
        {
            width = w;
            height = h;
        }
        public void Area()
        {
            Console.WriteLine("Square Area : {0}", width * height);
        }
        public void Girth()
        {
            Console.WriteLine("Square Girth : {0}", (width + height) * 2);
        }
        public void Draw()
        {
            Console.WriteLine("Square");
        }
    }

    class Circle : Figure {
        int radius;

        public Circle(int r)
        {
            radius = r;
        }
        public void Area()
        {
            Console.WriteLine("Circle Area : {0}", radius * radius * 3.14);
        }
        public void Girth()
        {
            Console.WriteLine("Circle Girth : {0}", (radius * 2) * 3.14);
        }
        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(4, 5);
            Circle c = new Circle(3);

            c.Draw();
            c.Area();
            c.Girth();

            s.Draw();
            s.Area();
            s.Girth();
        }
    }
}
