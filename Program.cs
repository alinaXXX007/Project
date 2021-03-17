using System;

namespace Project
{
    class Program
    {
        static void Laba1()
        {
            //"Лабораторна 1"
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

        static void Laba2()
        {
            //Лабораторна 2"

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


            //Завдання на metanit

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

        }

        static void Main(string[] args)
        {
            //Лабораторна робота 3


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
            //Console.WriteLine($"Різниця між max i min = {a}");


            //Console.WriteLine("Task 8.41");
            //for (int i = 0; i <= 30; i++)
            //    for (int j = 0; j <= 30; j++)
            //        for (int k = 0; k <= 30; k++)
            //            if (i * i + j * j == k * k)

            //                if (i != j)
            //                {
            //                    Console.WriteLine($"{i}, {j}");
            //                }


            //tasks in metanit

            //task1
            //Console.WriteLine("Введіть суму вкладу:");
            //decimal sum = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Введіть кількість місяців::");
            //int b = Convert.ToInt32(Console.ReadLine()); 
            //for (int i = 0; i <= b; i++)
            //{
            //    sum += sum * 0.07M;

            //}
            //Console.WriteLine($"Кінцева сума вкладу: {sum}");


            //task2
            //Console.WriteLine("Введіть суму вкладу:");
            //decimal sum = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Введіть кількість місяців::");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //while (i <= b)
            //{
            //    sum += sum * 0.07M; 
            //    i++;
            //}
            //Console.WriteLine($"Кінцева сума вкладу: {sum}");



            //task3
            //for (int i=1; i<=10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i}*{j}={i * j}\t");
            //    }
            //    Console.WriteLine(" ");
            //}



            //task4 
            //while (true)
            //{
            //    Console.WriteLine("Введіть a:");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Введіть b:");
            //    int b = Convert.ToInt32(Console.ReadLine());

            //    if (a>=0 &&a<=10 && b>=0 && b<=10)
            //    {
            //        Console.WriteLine($"{a * b}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Дані числа не припустимі");

            //    } 
            //}






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





            //Лабораторна робота 4

            //Console.WriteLine("Task 11.11");
            //int[] myArrey = new int[20];
            //Random rand = new Random();
            //for (int i=0; i<myArrey.Length; i++)
            //{
            //    myArrey[i] = rand.Next(20);
            //    Console.WriteLine($"{myArrey[i]}");
            //}


            //Console.WriteLine("Task 11.17a,b,c");
            //int[] myArrey = new int[5]; 
            //Random rand = new Random();
            //for (int i = 0; i < myArrey.Length; i++)
            //{
            //    myArrey[i] = rand.Next(20); 
            //    Console.Write($"{myArrey[i ]} ");

            //}
            //Console.WriteLine(" ");
            //for (int i = 0; i < myArrey.Length; i++)
            //{
            //    myArrey[i] = 2 * myArrey[i];
            //    Console.Write($"{myArrey[i]} ");
            //}
            //Console.WriteLine(" ");
            //Console.Write("Введіть число А");
            //int A = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < myArrey.Length; i++)
            //{
            //    myArrey[i] = myArrey[i]-A;
            //    Console.Write($"{myArrey[i]} ");
            //}
            //Console.WriteLine(" ");
            //for (int i = 0; i < myArrey.Length; i++)
            //{
            //    myArrey[i] = myArrey[i]/myArrey[0];
            //    Console.Write($"{myArrey[i]} ");
            //}


            //Console.WriteLine("Task 11.41");
            //int[] myArrey = new int[5];
            //Random rand = new Random();
            //for (int i = 0; i < myArrey.Length; i++)
            //{
            //    myArrey[i] = rand.Next(20);
            //    Console.Write($"{myArrey[i]} ");  
            //}

            //Console.WriteLine(" ");
            //for (int i = 0; i < myArrey.Length; i++)
            //{
            //    if (myArrey[i] %2== 0)
            //    {

            //        Console.Write($"Парні елементи: {myArrey[i]} ");

            //    }  
            //}
            //Console.WriteLine(" ");
            //for (int i = 0; i < myArrey.Length; i++)
            //{
            //    if (myArrey[i] % 2 != 0)
            //    {

            //        Console.Write($"Непарні елементи: {myArrey[i]} ");

            //    }
            //}



            //Console.WriteLine("Task 11.65");
            //double[] myArrey = new double[28];
            //Random rand = new Random();
            //for (int i = 0; i < myArrey.Length; i++)
            //{
            //    myArrey[i] = rand.Next(28);
            //    Console.Write($"{myArrey[i]} ");
            //}
            //Console.WriteLine(" ");
            //int count;
            //count = 0;
            //for (int i = 0; i < myArrey.Length; i++)
            //{
            //    if (myArrey[i] == 0)
            //    {
            //        count += 1; 
            //    } 
            //}
            //Console.Write($" кі-сть днів коли осадки =0 :{count}");



            //Console.WriteLine("Task 11.89");
            //double[] hight = new double[13] { -154, -176, 155, 167, -154, 153, 155, 166, -170, 164, 159, 167, -170 };
            //double girlHight = 0;
            //double boyHight = 0;
            //int countB = 0;
            //int countG = 0;
            //foreach (double item in hight)
            //{

            //    if (item < 0)
            //    {
            //        countB += 1;
            //        boyHight += item;
            //    }
            //    else
            //    {
            //        countG += 1;
            //        girlHight += item;
            //    }

            //}
            //string c = ((boyHight / countB) - (girlHight / countG) >= 10) ? "так середній зріст хлопців більший на 10см" : "середній зріст не більше на 10";
            //Console.WriteLine($"{boyHight * (-1)}");
            //Console.WriteLine($"{countB}");
            //Console.WriteLine($"{girlHight}");
            //Console.WriteLine($"{countG}");
            //Console.WriteLine($"{c}");



            //Console.WriteLine("Task 11.113");
            //double[] myArrey = new double[10];
            //Random rand = new Random();
            //for (int i = 0; i < myArrey.Length; i++)
            //{
            //    myArrey[i] = rand.Next(1930,2010);
            //    Console.Write($"{myArrey[i]} ");
            //}
            //Console.WriteLine(" ");
            //int max = 0;
            //bool a=true;
            //foreach(int item in myArrey)
            //{
            //    if (a)
            //    {
            //        max = item;
            //        a = false;
            //    }
            //    else
            //    {
            //        if (max<item)
            //        {
            //            max = item;
            //        }

            //    }
            //}
            //Console.WriteLine(" ");
            //int min = 0;
            //bool b = true;
            //foreach (int item in myArrey)
            //{
            //    if (b)
            //    {
            //        min = item;
            //        b = false;
            //    }
            //    else
            //    {
            //        if (min > item)
            //        {
            //            min = item;
            //        }

            //    }
            //}
            //int difference = max - min;
            //Console.WriteLine($"{max}=max");
            //Console.WriteLine($"{min}=min");
            //Console.WriteLine($"{difference} років = різниця між найстаршим і намолодшим.");



            //Console.WriteLine("Task 11.137");
            //float[] a = new float[20];
            //Random rand = new Random();
            //for (int item = 0; item < a.Length; item++)
            //{
            //    a[item] = rand.Next(20);
            //    Console.Write($"{a[item]} ");
            //}

            //Console.WriteLine(" ");
            //int i, max1, max2, buff;
            //if (a[0] > a[1])
            //{
            //    max1 = 1;
            //    max2 = 0;
            //}
            //else {
            //    max1 = 0;
            //    max2 = 1;
            //} 
            //for(i = 2 ; i < a.Length; i++ ) {
            //    if (a[i] > a[max1])
            //    {
            //        buff = max1;
            //        max1 = i;
            //        if (a[buff] > a[max2]) max2 = buff;
            //    }
            //    else {
            //        if (a[i] > a[max2]) max2 = i;
            //    }
            //} 
            //Console.Write($"{a[max1]} -- перше місце, {a[max2]}--друге місце");


            //Павловська Лабораторна робота №5 17варіант a
            //int[] myArrey = new int[15];
            //Random rand = new Random();
            //for (int i = 0; i < myArrey.Length; i++)
            //{
            //    myArrey[i] = rand.Next(-20,20) ;
            //    Console.Write($"{myArrey[i]} ");
            //}
            //Console.WriteLine(" ");
            //int count = 0;
            //foreach (int item in myArrey)
            //{
            //    if (item>=0)
            //    {
            //        count += 1;
            //    }

            //}
            //Console.Write($"Кількість додатніх елементів в масиві{count}");



            //Павловська Лабораторна робота №5 17варіант b
            //int[] myArrey = new int[15];
            //Random rand = new Random();
            //for (int item = 0; item < myArrey.Length; item++)
            //{
            //    myArrey[item] = rand.Next(5);
            //    Console.Write($"{myArrey[item]} ");
            //}
            //Console.WriteLine(" ");

            //int i = myArrey.Length-1;
            //int sum = 0;
            //while (i>0)
            //{
            //    sum += myArrey[i];
            //    i--;
            //    if (myArrey[i] == 0)
            //    {
            //        break;
            //    }

            ////}
            //Console.Write($"{sum}");




            //Console.WriteLine("Сортування масиву методом вибору");

            //int[] A = new int[10];
            //Random rand = new Random();
            //for (int item = 0; item < A.Length; item++)
            //{
            //    A[item] = rand.Next(10);
            //    Console.Write($"{A[item]} ");
            //}
            //Console.WriteLine(" ");

            //for (int i = 1; i < A.Length; i++)
            //{
            //    int x = A[i];
            //    int j = i;
            //    while (j > 0 && A[j-1]>x)
            //    {
            //        A[j] = A[j - 1];
            //        j--;
            //    }
            //    A[j] = x;

            //}
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"{A[i]}, ");
            //}


             

            //Console.WriteLine("Сортування масиву методом вставки");
            //int[] b = new int[10];
            //Random rand = new Random();
            //for (int item = 0; item < b.Length; item++)
            //{
            //    b[item] = rand.Next(10);
            //    Console.Write($"{b[item]} ");
            //}
            //Console.WriteLine(" ");
            //int i;

            //for (i = 1; i < b.Length; i++)
            //{
            //    int key = b[i];
            //    int j = i - 1;
            //    while (j >= 0 && b[j] > key)
            //    {
            //        b[j + 1] = b[j];
            //        b[j] = key;
            //        j--; 
            //    }    
            //}
            //for ( i = 0; i < b.Length; i++)
            //{
            //    Console.Write($"{b[i]}, ");
            //}




































        }
    }
}
