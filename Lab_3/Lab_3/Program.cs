using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int n = int.Parse(Console.ReadLine());
            int a = n / 100;
            int c = n % 10;
            int b = n % 100 / 10;
            if (a == b || b == c || a == c)
            {
                Console.WriteLine("Некоторые цифры трехзначного числа одинаковые");
            }
            else
            {
                Console.WriteLine("Все цифры трехзначного числа не одинаковые");
            }
        }
    }
}
