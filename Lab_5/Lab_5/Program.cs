using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 4;
            int M = 4;
            int[,] matrix = new int[N, M];
            Random RandomNumber = new Random();
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < M; i++)
                {
                    
                    matrix[i, j] = RandomNumber.Next(-10 , 10);
                    Console.Write($"{matrix[j, i]}  ");

                }
                Console.WriteLine(" ");
            }

            int otvet = 0, t = 0, temp = 0, count = 0, totalCount = 0;
                                                                 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    temp = matrix[j,i];
                    int index = j;
                    for (int k = index + 1; k < M; k++)
                    {                                  
                        if (temp == matrix[++index,i])
                        {
                            count++;
                        }
                    }
                   if (otvet < count)
                    {                 
                        otvet = count + 1;
                    }                    
                    count = 0;
                   if (totalCount <= otvet)
                    {
                        totalCount = otvet;
                        t = i;
                    }
                    otvet = 0;
                }
                i++;
            }

            Console.WriteLine("Otvet: " + totalCount + "\n");
            Console.WriteLine("Nomer stolbtca: " + (t + 1));







        }
    }
}
