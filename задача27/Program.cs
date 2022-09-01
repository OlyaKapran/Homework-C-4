using System;

namespace задача27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int x=Convert.ToInt32(Console.ReadLine());
            int n=x;
            int sum = 0;
            while (x > 0)
            {
                sum = sum + x % 10;
                x = x /10 ;
            }
            Console.WriteLine($"Cумма цифр в числе {n} = " + sum);
            

        }
    }
}
