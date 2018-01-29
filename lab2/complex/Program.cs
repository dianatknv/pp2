using System;

namespace complex
{
    class Complex
    {
        public int x, y;

        public Complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            int a = c1.x + c2.x; 
            int b = c1.y + c2.y;
            Complex n = new Complex(a, b);
            return n;
        }

        public override string ToString()
        {
            return x + " + " + y + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(5, 3);
            Complex c2 = new Complex(1, 2);
            Complex sum = c1 + c2;
            Console.WriteLine("The sum: " + sum);
        }
    }
}
