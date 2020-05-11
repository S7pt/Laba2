using System;

namespace _2._5
{
    class Program
    {
        static int FindMinimalElementSum(int[,] a,int n,int m)
        {
            int minimalSum = 0;
            int minimal;
            for(int i = 0; i < n; i++)
            {
                minimal = a[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (minimal > a[i, j])
                    {
                        minimal = a[i, j];
                    }
                }
                minimalSum += minimal;
            }
            return minimalSum;
        }
        static void Main(string[] args)
        {
            int[,] a;
            Console.Write("Вкажіть розмір масиву(n):");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Вкажіть розмір масиву(m):");
            int m = int.Parse(Console.ReadLine());
            a = new int[n, m];
            Random randomizer = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = randomizer.Next(-100, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    Console.Write("\t" + a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сума мінімальних елементів масиву дорівнює " + FindMinimalElementSum(a, n, m));
        }
    }
}
