using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Решение для 5.2 " + Telega());
            Console.WriteLine("Введите текст для транслитерации");
            string str = Console.ReadLine();
            Console.WriteLine(Trans(str));


        }
        static string Trans(string str)
        {
            str = str.ToUpper();
            str = str.Replace("А", "A");
            str = str.Replace("Б", "B");
            str = str.Replace("В", "V");
            str = str.Replace("Г", "G");
            str = str.Replace("Д", "D");
            str = str.Replace("Е", "E");
            str = str.Replace("Ё", "E");
            str = str.Replace("Ж", "ZH");
            str = str.Replace("З", "Z");
            str = str.Replace("И", "I");
            str = str.Replace("Й", "I*");
            str = str.Replace("К", "K");
            str = str.Replace("Л", "L");
            str = str.Replace("М", "M");
            str = str.Replace("Н", "N");
            str = str.Replace("О", "O");
            str = str.Replace("П", "P");
            str = str.Replace("Р", "R");
            str = str.Replace("С", "S");
            str = str.Replace("Т", "T");
            str = str.Replace("У", "U");
            str = str.Replace("Ф", "KH");
            str = str.Replace("Х", "TS");
            str = str.Replace("Ц", "TS");
            str = str.Replace("Ч", "CH");
            str = str.Replace("Ш", "SH");
            str = str.Replace("Щ", "SHCH");
            str = str.Replace("Ь", "-");
            str = str.Replace("Ы", "Y");
            str = str.Replace("Ъ", "IE");
            str = str.Replace("Э", "E");
            str = str.Replace("Ю", "IU");
            str = str.Replace("Я", "IA");

            return str;


        }
        static string Telega()
        {
            string str = "телега";
            char[] sRev = str.ToCharArray();
            Array.Reverse(sRev);
            string str2 = new string(sRev);
            return str + " = " + str.Substring(2, 4) + str.Substring(0, 1) + " " + str[5] + str[0] + str2.Substring(3, 3);
        }
    }
}
