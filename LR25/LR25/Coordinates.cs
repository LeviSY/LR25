using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace LR25
{
    class Coordinates
    {
        public double l = 0;

        int x1;
        int x2;
        int x3;
        int y1;
        int y2;
        int y3;

        public void points()
        {

            string path = @"C:\Users\Levi\source\repos\LR25\LR25\Coordinates\coord.txt";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                sr.ReadLine();
                Console.Clear();

                x1 = Convert.ToInt32(sr.ReadLine());
                x2 = Convert.ToInt32(sr.ReadLine());
                x3 = Convert.ToInt32(sr.ReadLine());
                y1 = Convert.ToInt32(sr.ReadLine());
                y2 = Convert.ToInt32(sr.ReadLine());
                y3 = Convert.ToInt32(sr.ReadLine());
            }
        }
        public void longer()
        {
            a:
            WriteLine("     Выберите отрезок      ");
            WriteLine("===========================");
            WriteLine("1) AB");
            WriteLine("2) BC");
            WriteLine("3) CA");
            WriteLine("===========================");
            WriteLine("     Координаты точек     ");
            WriteLine("A(" + x1 + ";" + y1 + ")");
            WriteLine("B(" + x2 + ";" + y2 + ")");
            WriteLine("C(" + x3 + ";" + y3 + ")");
            WriteLine("===========================");
            int num = Convert.ToInt32(ReadLine());

            if (num <= 3 && num > 0)
            {
                if (num == 1)
                {
                    l = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                }
                if (num == 2)
                {
                    l = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
                }
                if (num == 3)
                {
                    l = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
                }
            }
            else
            {
                WriteLine("Такого отрезка не существует");
                goto a;
            }
            l = Math.Round(l, 2);
            WriteLine("Длина отрезка = " + l);
        }

        public void area()
        {
            WriteLine("     Координаты точек     ");
            WriteLine("A("+x1+";"+y1+")");
            WriteLine("B("+x2+";"+y2+")");
            WriteLine("C("+x3+";"+y3+")");
            WriteLine("===========================");
            double A = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double B = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double C = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));

            A = Math.Round(A, 2);
            B = Math.Round(B, 2);
            C = Math.Round(C, 2);

            double p = (A + B + C) / 2;

            p = Math.Round(p, 2);

            double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            S = Math.Round(S, 2);

            WriteLine("Площадь треугольника = " + S);
        }

        public void menu()
        {
            WriteLine("        Выберите действие       ");
            WriteLine("================================");
            WriteLine("1) Получить длину стороны");
            WriteLine("2) Получить площадь треугольника");
            WriteLine("================================");
            WriteLine("    Для выхода введите - Exit   ");
        }
    }
}
