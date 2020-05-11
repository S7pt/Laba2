using System;
namespace ConsoleApp1
{
    public class Program
    {
        public static int FindMinimal(int[] a)
        {
            int index = 0;
            int minimal = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (minimal > a[i])
                {
                    minimal = a[i];
                    index = i;
                }
            }
            return index;
        }
        public static int CompositionBeforeNull(int[] a)
        {
            int counter = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    return counter;
                }
                else
                {
                    counter *= a[i];
                }
            }
            return counter;
        }
        static int Main(string[] args)
        {
            Console.WriteLine("Введіть кількість елементів масиву");
            int index = int.Parse(Console.ReadLine());
            int choice;
            int[] a = new int[index];
            Console.WriteLine("1.Генерація масиву автоматично\n2.Введення масиву вручну");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    {
                        Random randomizer = new Random();
                        for (int i = 0; i < index; i++)
                        {
                            a[i] = randomizer.Next(-100, 100);
                        }
                        foreach (int x in a)
                        {
                            Console.WriteLine("\t" + x);
                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < index; i++)
                        {
                            a[i] = int.Parse(Console.ReadLine());
                        }
                        foreach (int x in a)
                        {
                            Console.WriteLine("\t" + x);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("\aНевірний символ, спробуйте знову");
                        return 0;
                    }

            }
            Console.WriteLine("1)Індекс мінімального елементу масиву = " + FindMinimal(a));
            Console.WriteLine("2)Добуток елементів масиву до нульового = " + CompositionBeforeNull(a));
            return 0;
        }
    }
}
