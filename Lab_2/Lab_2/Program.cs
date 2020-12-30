using System;

namespace Lab_2
{
    class Program
    {
        static void Main()
        {
           
            {
                double n, k;
                Console.WriteLine("Enter (n) and (k) ");
                n = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());

                double u = 1;

                for (int i = 0; i < k; i++)
                {
                    u *= (3 * k + Math.Pow(-1, ((Math.Pow(k, 2)) - k + 1)) * k) / (2 * Math.Pow(k, 2) + 1);
                }
                Console.WriteLine("u=" + u);
            }


        }
    }

}
