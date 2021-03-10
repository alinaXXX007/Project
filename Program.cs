using System;

namespace Project
{
    class Program
    {
        static void Laba1()
        {
            Console.WriteLine("Лабораторна 1");
            string buf;
            Console.WriteLine("Input m: ");
            buf = Console.ReadLine();
            double m = Convert.ToDouble(buf);

            double y = -Math.Sqrt(m);

            double y1 = Math.Sqrt(Math.Pow((3 * m + 2), 2) - 24 * m) / (3 * Math.Sqrt(m) - 2 / Math.Sqrt(m));

            Console.WriteLine($"m = {m}");
            Console.WriteLine("Result =" + y);
            Console.WriteLine("Result =" + y1);


        }

        static void Main(string[] args)
        {
            

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


            //Console.WriteLine("Вправа 7");
            //int a, b, num;
            //Console.Write("Введіть a: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введіть b: ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введіть номер операції: ");
            //num = Convert.ToInt32(Console.ReadLine());
            //switch (num)
            //{
            //    case 1:
            //        num = a + b;
            //        Console.WriteLine($"Складення операція, num= {num}");

            //        break;
            //    case 2:
            //        num = a - b;
            //        Console.WriteLine($"Віднімання операція, num= {num}");
            //        break;
            //    case 3:
            //        num = a * b;
            //        Console.WriteLine($"Множення операція, num= {num}");
            //        break;
            //    default:
            //        Console.WriteLine("Операція невизначена");
            //        break;
            //}


            //laba 2
            //Console.WriteLine("task 5.17a");
            //int x, t;
            //for (x = 4; x < 28; x++)
            //{
            //    t = x + 2;
            //    int y = Convert.ToInt32((2 * Math.Pow(t, 2)) + 5);
            //    Console.WriteLine($"y={y}");
            // }

            //Console.WriteLine("task 5.17b");
            //int x, t;
            //for (x = 4; x < 28; x++)
            //{
            //    t = x + 2;
            //    int y = 5*t-2;
            //    Console.WriteLine($"y={y}");
            //}


            //Console.WriteLine("task 5.23");
            //double x;
            //for (x = 2.1; x < 2.9; x=x+0.10)
            //{
            //    x = Math.Round(x, 2);
            //    Console.WriteLine($"x={x}");
            //}


            //Console.WriteLine("task 5.26");
            //double x;
            //for (x = 4.4; x < 6.6; x = x + 0.2)
            //{
            //    x = Math.Round(x, 2);
            //    Console.WriteLine($"x={x}");
            //}


            //Console.WriteLine("task 5.41"); 
            //double sum = 0;
            //int[] nums = new int[12] {1,1,1,1,1,1,1,1,1,1,1,1};
            //for (int i = 0; i<= 12; i++)
            //{
            //    sum += nums[i];
            //    Console.WriteLine($"Загальна маса предметів = {sum}");
            //}



            //Console.WriteLine("Task 5.65");
            //int country = 4;
            //double S = 0;   
            //for (int i = 0; i < country; i++)
            //{
            //    Console.Write("Введіть чисельність населення" + (i + 1) + "-ї країни:");
            //    int s = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Введіть її площа:");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    S += a;
            //}
            //Console.Write($"Загальна площа країни: {S}");


            //Console.WriteLine("Task 5.89");
            //int sum = 0;
            //int f=1;
            //for (int i=1; i<=10; i++)
            //{
            //    f = f * i;
            //    sum += f;

            //}
            //Console.WriteLine($"{sum}");


            //Console.WriteLine("task 6.17");
            //Console.Write("input a = ");
            //double a;
            //int n;
            //n = 1;
            //a = Convert.ToDouble(Console.ReadLine());
            //while (1/n>a) 
            //{

            //    Console.WriteLine($"n ={n}");
            //    n += 1;
            //}



            //Console.WriteLine("task 7.17");
            //double sum = 0;
            //Console.Write("input n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] m = new int[12] { 2, 4, 6, 2, 3, 7, 5, 9, 6, 3, 4, 6 };
            //for (int i = 0; i <= 12; i++)
            //{
            //    if (m[i] % n == 0)
            //        sum += m[i];
            //    Console.WriteLine($"Загальна маса предметів = {sum}");

            //} 


            //Console.WriteLine("Task 6.41a");
            //Console.Write("input a= ");
            //int m, a;
            //a = Convert.ToInt32(Console.ReadLine());
            //m = a % 10;
            //a = a / 10;
            //while (a>0)
            //{
            //    if (a % 10 > m)
            //        m = a % 10;
            //    a = a / 10;

            // }
            //Console.WriteLine($"{m}");


            //Console.WriteLine("Task 6.41b");
            //Console.Write("input a= ");
            //int m, a;
            //a = Convert.ToInt32(Console.ReadLine());
            //m = a % 10;
            //a = a / 10;
            //while (a > 0)
            //{
            //    if (a % 10 < m)
            //        m = a % 10;
            //    a = a / 10;

            //}
            //Console.WriteLine($"{m}");



            //Console.WriteLine("Task 6.65");
            //int[] a = new int[15] { 1, 4, 4, 2, 3, 7, 5, 9, 1, 1, 3, 6, 3, 6, 6 };
            //int i1 = 0;
            //int i2 = 0;
            //for (int i = 0; i < 14; i++)
            //{
            //    for (int j = i + 1; j < 15; j++)
            //    {
            //        if (a[i] == a[j])
            //        {
            //            i1 = i;
            //            i2 = j;

            //        }
            //    }
            //}
            //if (i1 != i2) 
            //    {
            //    Console.WriteLine($"{i1}, {i2}");
            //    }
            //else  
            //{
            //    Console.WriteLine("All numbers are different"); 
            //}



            //Console.WriteLine("Task 7.41");
            //int[] a = new int[15] { 2, 2, 2, 5, 3, 3, 4, 4, 4, 4, 5, 5, 3, 5, 5 };
            //int A = 0;
            //int B = 0;
            //int C = 0;
            //int D = 0;
            //for (int i = 0; i < 15; i++)
            //{
            //    if (a[i] == 5)
            //        A++;
            //    else if (a[i] == 4)
            //        B++;
            //    else if (a[i] == 3)
            //        C++;
            //    else
            //        D++;

            //}
            //Console.WriteLine($"A={A}, B={B}, C={C}, D={D}");



            //Console.WriteLine("Task 7.65");
            //float[] b = new float[10] { 7,8, 3, 4, 2, 5, 8, 7, 22, 3 };
            //float max;  
            //int index;   
            //int i;
            //index = 0;
            //max = b [0]; 
            //for (i = 1; i < 10; i++)
            //    if (max < b [i])
            //    {
            //        max = b[i];  
            //        index = i;  
            //    }
            //float min = b[0];
            //for (i = 1; i < 10; i++)
            //    if (min > b[i])
            //    {
            //        min = b[i];
            //        index = i;
            //    }
            //float a = max - min;
            //Console.WriteLine($"max={max}");
            //Console.WriteLine($"min={min}");
            //Console.WriteLine($"Різниця між на max i min = {a}");



            //Console.WriteLine("Task порахувати кількість простих чисел"); 
            //int i, count, j, n; 
            //count= 10;
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("input n: ");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    for (j = 2; j <= (Math.Sqrt(n)) + 1; j++)
            //        if (n % j == 0)
            //        {
            //            count -= 1;
            //            break;
            //        }
            //}
            //    Console.WriteLine($"{count} ");



            //Console.WriteLine("Сортування масиву методом вставки"); 
            //int[] b = new int[10] { 7, 8, 3, 4, 2, 5, 8, 7, 22, 3 };
            //int i, j; 
            //int t;
             
            //for (i = 0; i < 9; i++)
            //    for (j = i; j >= 0; j--)
            //        if (b[j] < b[j + 1])
            //        {
            //            t = b[j];
            //            b[j] = b[j + 1];
            //            b[j + 1] = t;
            //            Console.Write($"{t} ");

            //        }
            







        }
    }
}
