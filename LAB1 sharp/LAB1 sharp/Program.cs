using System;
namespace LAB1_sharp
{
    class Program
    {
        static void Main()
        {
            int V1, V2;
            float temp1, temp2;
            Console.WriteLine("Количество литров первой жидкости v1=");
            V1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Количество литров второй жидкости v2=");
            V2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Температура первой жидкости temp1=");
            temp1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Температура второй жидкости temp2=");
            temp2 = int.Parse(Console.ReadLine());


            float T;
            T = (V1 * temp1 + V2 * temp2) / (V1 + V2);

            Console.WriteLine($"Общая температура={T}");

            Console.ReadKey();
        }
    }
}
