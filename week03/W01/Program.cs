using System;

namespace w01
{
    class Fraction
    {
        public int numerator;       //분자
        public int denominator;     //분모
        
        public Fraction(int x) : this(x,1) { }
        public Fraction(int x, int y)
        {
            numerator = x;
            denominator = y;
        }
        public new string ToString()
        {
            return numerator + "/" + denominator;
        }

        int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        static int g;
        public void IF()
        {
            if (this.denominator == this.numerator)
            {
                this.denominator = 1;
                this.numerator = 1;
                return;
            }
            else if (this.denominator > this.numerator)
            {
                if (this.numerator < 0)
                {
                    g = GCD(this.denominator, this.numerator*(-1));
                }
                else 
                    g = GCD(this.denominator, this.numerator);
            }
            else
            {
                g = GCD(this.numerator, this.denominator);
            }
            this.denominator = this.denominator/g;
            this.numerator = this.numerator/g;
        }

        int rstD;
        int rstN;

        public Fraction Add(Fraction f)
        {
            rstD = f.denominator * this.denominator;
            rstN = (this.numerator * f.denominator) + (f.numerator * this.denominator);
            return new Fraction(rstN, rstD);
        }
        public Fraction Sub(Fraction f)
        {
            rstD = f.denominator * this.denominator;
            rstN = (this.numerator * f.denominator) - (f.numerator * this.denominator);
            return new Fraction(rstN, rstD);
        }
        public Fraction Mult(Fraction f)
        {
            rstD = f.denominator * this.denominator;
            rstN = this.numerator * f.numerator;
            return new Fraction(rstN, rstD);
        }
        public Fraction Div(Fraction f)
        {
            rstD = f.numerator * this.denominator;
            rstN = this.numerator * f.denominator;
            return new Fraction(rstN, rstD);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction c1, c2;
            c1 = new Fraction(1, 2);
            c2 = new Fraction(3, 4);

            Fraction add = c1.Add(c2);
            Fraction sub = c1.Sub(c2);
            Fraction mult = c1.Mult(c2);
            Fraction div = c1.Div(c2);

            add.IF();
            sub.IF();
            mult.IF();
            div.IF();

            Console.WriteLine("{0} + {1} = {2}",c1.ToString(), c2.ToString(), add.ToString());
            Console.WriteLine("{0} - {1} = {2}", c1.ToString(), c2.ToString(), sub.ToString());
            Console.WriteLine("{0} * {1} = {2}", c1.ToString(), c2.ToString(), mult.ToString());
            Console.WriteLine("{0} / {1} = {2}", c1.ToString(), c2.ToString(), div.ToString());
        }
    }

}

