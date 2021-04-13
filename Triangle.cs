using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Triangle
    {
        int a;
        public int A
        {
            get{ return a; }
            set { a = value; }
        }
        int b;
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        int c;
        public int C
        {
            get { return c; }
            set { c = value; }
        }
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Length(int a, int b, int c)
        {
            Console.WriteLine($"{a}, {b}, {c}");
        }
        public void Perm(int a, int b, int c)
        {
            int p = a + b + c;
            Console.WriteLine($"{p}");
        }
        public void Square(int a, int b, int c, int p)
        {
            int S = Convert.ToInt32(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            Console.WriteLine($"{S}");
        }
    }
}
