using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace Lab_7

{
        class Program
        {
            public static void Main(string[] args)
            {
                var lists = new List<int> { 2,46,23,12,0,32,3,1,8,9};
                int W = 0;
                int T = 0;

            for (int i = 0; i < lists.Count; i++)
            {
                if (lists[i] % 2 == 0)
                {
                    W -= lists[i];
                }
                else if (lists[i] % 2 != 0)
                {
                    T += lists[i];
                }

                Console.WriteLine(lists[i]);
            }
            Console.WriteLine("\n");


            Console.WriteLine("Сумма простих: " + T );
            Console.WriteLine("Рiзниця парних:" + W);
            }
        }
    
}

