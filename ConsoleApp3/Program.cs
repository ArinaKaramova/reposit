using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x;
            Console.WriteLine("Введите x:");
            x = double.Parse(Console.ReadLine());

            y = YFunction(x);
            Console.WriteLine("y =" + y);
        }

        static double YFunction(double x)
        {
            return (Math.Sqrt(Math.Sin(x) * Math.Sin(x) + 4) + Math.Tan(x)) / (Math.Cos(x) * Math.Cos(x) + 4);
        }
    }
}
