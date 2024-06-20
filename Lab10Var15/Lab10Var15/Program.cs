using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Var15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Введи число строк и столбцов: ");
            int n = int.Parse(Console.ReadLine());
            int[,] res = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[i, j] = 0;
                }
            }
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i; j++)
                {
                    res[i, j] = 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{res[i, j]} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            int[,] D = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    D[i, j] = random.Next(-10, 11);
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{D[i, j]} \t");
                }
            }
            int min = D[0, 0];
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i; j++)
                {
                    if (min > D[i, j])
                        min = D[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальный элемент в заштрихованной области= {min}");
            int ind = 0;
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i; j++)
                {
                    if (D[i, j] >= 0)
                        ind++;
                }
            }
            int[] X = new int[ind];
            int k = 0;
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i; j++)
                {
                    if (D[i, j] >= 0)
                    {
                        X[k] = D[i, j];
                        k++;
                    }
                }
            }
            Console.WriteLine($"Массив X: {string.Join(" ", X)}");
            Console.WriteLine();
            int[] R = new int[n / 2];
            for (int i = 0; i < n / 2; i++)
            {
                k = 0;
                for (int j = i; j < n - i; j++)
                {
                    if (D[i, j] > 0)
                        k++;
                }
                R[i] = k;
            }
            Console.WriteLine($"Массив R: {string.Join(" ", R)}");
            Console.WriteLine();
            int[,] res2 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res2[i, j] = 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    res2[i, j] = 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{res2[i, j]} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            int Summ = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    if (D[i, j] > 0)
                        Summ += D[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{D[i, j]} \t");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Сумма положительных элементов в левой части матрицы= {Summ}");
            Console.WriteLine();
        }
    }
}
