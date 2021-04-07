using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Complex
    {
        double a; 
        public double A { 
            get {
                return a;
            }
            set
            {
                a = value;
            }
             
        }
        double b;
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }

        }

        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
            
        }

        public Complex Add(Complex f)
        {
            return new Complex(a + f.a, b + f.b);
        }
        public Complex Sub(Complex f)
        {
            return new Complex(a - f.b, b - f.a);
        }
        public double Mn(Complex f)
        {
            return ((a * f.a - b * f.b)) * (a * f.b + b * f.a);
            
        }
        public double Div(Complex f)
        {
            return (a * f.a + b * f.b) / (f.a * f.a + f.b * f.b);
            
        }
        public void Equ(Complex f)
        {
            if (a==f.a && b == f.b)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

}

