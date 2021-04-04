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
            set {
                a = value;
            } 
        }
        double b;
        public double B { get; set; }



        public Complex(double a, double b)
        {
            this.a = a; 
            this.b = b;
           
             
        }

        public double Add(double c=4.5, double d=3.5)
        {
            return (a - b) + (c + d);
        }
        public double Sub(double a, double b, double c = 4.5, double d = 3.5)
        {
            return (a - b) - (c - d);
        }
        public double Mn(double a, double b, double c = 4.5, double d = 3.5)
        {
            return (a * c) - (b * d);
            
        }
        public double Div(double a, double b, double c = 4.5, double d = 3.5)
        {
            return (a*c+b*d)/(c*c+d*d);
            
        }
        public void Equ(double a, double b, double c = 4.5, double d = 3.5)
        {
            if (a==c && b == d)
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

