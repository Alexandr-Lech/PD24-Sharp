using System;
using System.Collections.Generic;
using System.Linq;

namespace IndividWork
{


    public static class Ext
    {
        public static void change(this int[] a)
        {

            int max = 0;
            int imax = 0;
            for (int i = 0; i < a.Length; i++)
            {
                
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





        }
    }



    class Program
    {


        static void Main(string[] args)
        {
            Random r = new Random();
            int[] a = new int[8];
            a.change();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }


        }
    }
}