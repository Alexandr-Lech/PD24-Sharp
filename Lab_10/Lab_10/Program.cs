using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_10
{
   




        public static class Ext
        {
            public static void change(this int[] a)
            {
                int max = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > 0)
                    {
                        a[i] = max;
                    }
                }





            }
        }



        class Program
        {


            static void Main(string[] args)
            {
            Random r = new Random();
            int[] a = new int[8];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{ (a[i] = r.Next(-50, 50))} " );

                a.change();
            }
            Console.WriteLine("\n ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}  ");
            }
            


            }
        }
    }