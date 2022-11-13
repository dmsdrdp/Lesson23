using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);
            Console.ReadKey();
        }

        static void Factorial(int n)                       // Метод нахождения факториала
        {
            int f = 1;
            for (int i = 1; i < n + 1; i++)
            {
                f *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine(f);
        }

        static async void FactorialAsync(int n)            //Асинхронный метод нахождения факториала
        {
            await Task.Run(()=>Factorial(n));               
        }

    }
}

