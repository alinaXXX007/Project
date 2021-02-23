using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Лабораторна 1");
            //string buf;
            //Console.WriteLine("Input m: ");
            //buf = Console.ReadLine();
            //double m = Convert.ToDouble(buf);


            //double y = -Math.Sqrt(m);

            //double y1 = Math.Sqrt(Math.Pow((3 * m + 2), 2) - 24 * m) / (3 * Math.Sqrt(m) - 2 / Math.Sqrt(m));

            //Console.WriteLine($"m = {m}");
            //Console.WriteLine("Result =" + y);
            //Console.WriteLine("Result =" + y1);



            //Console.WriteLine("Лабораторна 2");

            /*
            Console.WriteLine("завдання 4.17 b");
            double a, b;
            Console.WriteLine("Площа кола =");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площа трикутника =");
            b = Convert.ToInt32(Console.ReadLine());
            if (a >= b * Math.PI * 4 / (3 * Math.Sqrt(3))) 
                Console.WriteLine("трикутник поміститься в колі");
            else
                Console.WriteLine("трикутник не поміститься в колі"); */

            /*
            Console.WriteLine("завдання 4.33");
            double x;
            Console.WriteLine("введіть число ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0 & x >= 0) 
                Console.WriteLine("задане число є парним");
            else
                Console.WriteLine("задане число непарне"); */


            /*
            Console.WriteLine("завдання 4.49");
            int a, b, c, d, x1, x2;
            Console.WriteLine("input a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input c=");
            c = Convert.ToInt32(Console.ReadLine());
            d = b * b - 4 * a * c;
            x1 =Convert.ToInt32( -b + Math.Sqrt(d) / 2 * a);
            x2 = Convert.ToInt32(-b - Math.Sqrt(d) / 2 * a);
            if (d == 0 & a != 0)
                Console.WriteLine($"Рівняння має 1 корінь, d= {d} x={x1}");
            else if (d >= 0 & a != 0)
                Console.WriteLine($"Рівняння має >1 кореня d= {d} x1={x1}, x2={x2}");
            else
                Console.WriteLine($"Рівняння не має коренів"); */


            //Console.WriteLine("Завдання 4.65");
            //int n;
            //Console.WriteLine("Введіть значення n= ");
            //n= Convert.ToInt32(Console.ReadLine());
            //if ((n % 4 == 0 && n % 100 != 0) || n % 400 == 0)
            //    Console.WriteLine("Рік високосний");
            //else
            //    Console.WriteLine("Рік не високосний");


            //Console.WriteLine("task 4.108");
            //Console.WriteLine("Введіть число від 1 до 4");
            //string m =Console.ReadLine();
            //switch (m)
            //{
            //    case "1":
            //        Console.WriteLine("Ваша карта піки");
            //        break;
            //    case "2":
            //        Console.WriteLine("Ваша карта трефи");
            //        break;
            //    case "3":
            //        Console.WriteLine("Ваша карта бубни");
            //        break;
            //    case "4":
            //        Console.WriteLine("Ваша карта черви");
            //        break;
            //    default:
            //        Console.WriteLine("Масть не існує");
            //        break;
            //}



            //Console.WriteLine("task 4.115");
            //int n, k, a;
            //Console.WriteLine("Введіть рік >=1984 ");
            //n = Convert.ToInt32(Console.ReadLine());
            //a = n % 12;
            //k = n % 10;
            //if (k == 4 | k == 5)
            //    if (a==4)
            //        Console.WriteLine("Green Krysa");
            //    if (a == 4)
            //        Console.WriteLine("Green Korowa");
            //    if (a == 4)
            //        Console.WriteLine("Green Tiger");
            //    if (a == 5)
            //        Console.WriteLine("Green Hare");
            //    if (a == 6)
            //        Console.WriteLine("Green Drakon");
            //    if (a == 7)
            //        Console.WriteLine("Green Snake");
            //    if (a == 8)
            //        Console.WriteLine("Green Horse");
            //    if (a == 9)
            //        Console.WriteLine("Green Viwtja");
            //    if (a == 4)
            //        Console.WriteLine("Green Manky");
            //    if (a == 4)
            //        Console.WriteLine("Green Piwen");
            //    if (a == 4)
            //        Console.WriteLine("Green Dog");
            //    if (a == 4)
            //        Console.WriteLine("Green Pig");

            //else if (k == 6 | k == 7)
            //    if (a == 4)
            //        Console.WriteLine("Red Krysa");
            //    if (a == 4)
            //        Console.WriteLine("Red Korowa");
            //    if (a == 4)
            //        Console.WriteLine("Red Tiger");
            //    if (a == 5)
            //        Console.WriteLine("Red Hare");
            //    if (a == 6)
            //        Console.WriteLine("Red Drakon");
            //    if (a == 7)
            //        Console.WriteLine("Red Snake");
            //    if (a == 8)
            //        Console.WriteLine("Red Horse");
            //    if (a == 9)
            //        Console.WriteLine("Red Viwtja");
            //    if (a == 4)
            //        Console.WriteLine("Red Manky");
            //    if (a == 4)
            //        Console.WriteLine("Red Piwen");
            //    if (a == 4)
            //        Console.WriteLine("Red Dog");

            //else if (k == 8 | k == 9)
            //    if (a == 4)
            //        Console.WriteLine("Yellow Krysa");
            //    if (a == 4)
            //        Console.WriteLine("Yellow Korowa");
            //    if (a == 4)
            //        Console.WriteLine("Yellow Tiger");
            //    if (a == 5)
            //        Console.WriteLine("Yellow Hare");
            //    if (a == 6)
            //        Console.WriteLine("Yellow Drakon");
            //    if (a == 7)
            //        Console.WriteLine("Yellow Snake");
            //    if (a == 8)
            //        Console.WriteLine("Yellow Horse");
            //    if (a == 9)
            //        Console.WriteLine("Yellow Viwtja");
            //    if (a == 4)
            //        Console.WriteLine("Yellow Manky");
            //    if (a == 4)
            //        Console.WriteLine("Yellow Piwen");
            //    if (a == 4)
            //        Console.WriteLine("Yellow Dog");
            //    if (a == 4)
            //        Console.WriteLine("Yellow Pig");
            //else if (k == 0 | k == 1)
            //    if (a == 4)
            //Console.WriteLine("White Krysa");
            //    if (a == 4)
            //Console.WriteLine("White Korowa");
            //    if (a == 4)
            //Console.WriteLine("White Tiger");
            //    if (a == 5)
            //Console.WriteLine("White Hare");
            //    if (a == 6)
            //Console.WriteLine("White Drakon");
            //    if (a == 7)
            //Console.WriteLine("White Snake");
            //    if (a == 8)
            //Console.WriteLine("White Horse");
            //    if (a == 9)
            //Console.WriteLine("White Viwtja");
            //    if (a == 4)
            //Console.WriteLine("White Manky");
            //    if (a == 4)
            //Console.WriteLine("White Piwen");
            //    if (a == 4)
            //Console.WriteLine("White Dog");
            //    if (a == 4)
            //Console.WriteLine("White Pig");
            //else if (k == 2 | k == 3)
            //    if (a == 4)
            //        Console.WriteLine("Black Krysa");
            //    if (a == 4)
            //        Console.WriteLine("Black Korowa");
            //    if (a == 4)
            //        Console.WriteLine("Black Tiger");
            //    if (a == 5)
            //        Console.WriteLine("Black Hare");
            //    if (a == 6)
            //        Console.WriteLine("Black Drakon");
            //    if (a == 7)
            //        Console.WriteLine("Black Snake");
            //    if (a == 8)
            //        Console.WriteLine("Black Horse");
            //    if (a == 9)
            //        Console.WriteLine("Black Viwtja");
            //    if (a == 4)
            //        Console.WriteLine("Black Manky");
            //    if (a == 4)
            //        Console.WriteLine("Black Piwen");
            //    if (a == 4)
            //        Console.WriteLine("Black Dog");
            //    if (a == 4)
            //        Console.WriteLine("Black Pig");


            //Console.WriteLine("Вправа 1 ");
            //int a, b;
            //Console.Write("Ввeдіть а:  ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введіть b: ");
            //b = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //    Console.WriteLine("Перше чило більше другого");
            //else if (a == b)
            //    Console.WriteLine("Два числа рівні");
            //else
            //    Console.WriteLine("Друге число більше першого");

            //Console.WriteLine("Вправа 2 ");
            //int a;
            //Console.Write("Ввeдіть будь-яке число:  ");
            //a = Convert.ToInt32(Console.ReadLine());
            //if (a > 5 & a<10)
            //    Console.WriteLine("Число більше 5 і менше 10");
            //else
            //    Console.WriteLine("Невідоме число");


            //Console.WriteLine("Вправа 3 ");
            //int a;
            //Console.Write("Ввeдіть будь-яке число:  ");
            //a = Convert.ToInt32(Console.ReadLine());
            //if (a == 5 || a == 10)
            //    Console.WriteLine("Число або дорівнює 5, або дорівнює 10");
            //else
            //    Console.WriteLine("Невідоме число");


            //Console.WriteLine("Вправа 4 ");
            //double a;
            //Console.Write("Ввeдіть суму вкладу:  ");
            //a = Convert.ToDouble(Console.ReadLine());
            //if (a <= 100)
            //{
            //    a += a * 0.05;
            //}
            //else if (a >= 100 & a <= 200)
            //{
            //    a += a * 0.07;
            //}
            //else if (a > 200)
            //{
            //    a += a * 0.10;
            //}
            //Console.WriteLine($"сума вкладу стала = {a}");


            //Console.WriteLine("Вправа 5 ");
            //double a;
            //Console.Write("Ввeдіть суму вкладу:  ");
            //a = Convert.ToDouble(Console.ReadLine());
            //if (a <= 100)
            //{
            //    a += a * 0.05;
            //}
            //else if (a >= 100 & a <= 200)
            //{
            //    a += a * 0.07;
            //}
            //else if (a > 200)
            //{
            //    a += a * 0.10;
            //}
            //Console.WriteLine($"сума вкладу стала = {a+15}");

            //Console.WriteLine("Вправа 6");
            //Console.Write("Введіть номер операції: ");
            //string num = Console.ReadLine();
            //switch (num)
            //{
            //    case "1":
            //        Console.WriteLine("Складення операція");
            //        break;
            //    case "2":
            //        Console.WriteLine("Віднімання операція");
            //        break;
            //    case "3":
            //        Console.WriteLine("Множення операція");
            //        break;
            //    default:
            //        Console.WriteLine("Операція невизначена");
            //        break;
            //}


            Console.WriteLine("Вправа 7");
            Console.Write("Введіть номер операції: ");
            string num = Console.ReadLine();
            switch (num)
            {
                case "1":
                    Console.WriteLine("Складення операція");
                    break;
                case "2":
                    Console.WriteLine("Віднімання операція");
                    break;
                case "3":
                    Console.WriteLine("Множення операція");
                    break;
                default:
                    Console.WriteLine("Операція невизначена");
                    break;
            }




        }
    }
}
