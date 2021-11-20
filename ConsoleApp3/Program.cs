using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, m1, m2, m3;
            Console.WriteLine("Введите первый катет");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второй катет");
            b = double.Parse(Console.ReadLine());

            c = Math.Sqrt(a * a + b * b);

            m1 = Median(a, b, c);
            m2 = Median(a, c, b);
            m3 = Median(b, c, a);

            Console.WriteLine("M1 = " + m1);
            Console.WriteLine("M2 = " + m2);
            Console.WriteLine("M3 = " + m3);
        }
        static double Median(double l1, double l2, double l3)
        {
            return Math.Sqrt(2 * l1 * l1 + 2 * l2 * l2 - l3 * l3) * 1 / 2;
        }
    }
}
