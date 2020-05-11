using System;

namespace _2_2
{
    class Program
    {
        static void FunctionSolver()
        {
            double a = -6;
            double y;
         
            while (a < 3)
            {
                y = Math.Pow(a, 4) - 12 * a + Math.Exp(a);
                Console.WriteLine("\tx=" + a + "\ty=" + y);
                a += 0.75;
            }
        }
        static void Main(string[] args)
        {
            FunctionSolver(); 

        }
    }
}
