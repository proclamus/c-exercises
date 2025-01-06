using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises_CSharp
{
    class Program
    {

        public static List<int> countingSort(List<int> arr)
        {
            int tamanhoArr = arr.Count();
            var arrCounter = new List<int>();

            for (int n = 0; n < tamanhoArr; n++)
            {
                arrCounter.Add(0);
            }

            for (int i = 0; i < tamanhoArr; i++)
            {
                foreach (int a in arr)
                {
                    if (i == a)
                    {
                        arrCounter[i] = arrCounter[i] + 1;
                    }
                }
            }

            return arrCounter;

        }

        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


        }

        public static int FlippingMatrix(List<List<int>> matrix)
        {
            int sum = 0;
            int n = matrix.Count;

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    sum +=
                        Math.Max(matrix[i][j],
                            (Math.Max(matrix[i][n - 1 - j],
                                    (Math.Max(matrix[n - 1 - i][j], matrix[n - 1 - i][n - 1 - j]))
                                )
                            )
                        );
                }
            }
            return sum;
        }



    }
}
