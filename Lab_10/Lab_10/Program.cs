using System;

namespace Lab_10
{
    class Program
    {
        static void Main()
        {
            Random r = new Random();
            int max = Int32.MinValue;
            int imax = 0;
            int[] a = new int[8];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write((a[i] = r.Next(-50, 50)) + " ");
                if (max < a[i])
                {
                    max = a[i];
                    imax = i;
                }
            }
            for (int i = 0; i < a.Length; i++)
                if (a[i] > 0)
                {
                 
                    a[i] = a[imax];

            }


            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.ReadKey();
        }
    }
}

