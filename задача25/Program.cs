using System;

namespace задача25
{
    class Program
    {
        static void Main(string[] args)
        {
            void Stepen()
            {
            Console.Write("Введите первое число ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}^{b} = " + Math.Pow(a, b)); 
            }
            Stepen();
        }
    }
}
