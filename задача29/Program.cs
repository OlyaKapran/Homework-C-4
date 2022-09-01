using System;

namespace задача29
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите количество элементов массива: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[N];

        void FillArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 100);
            }
        }
        void PrintArray()
        {
            foreach(int x in array)
            {
                Console.Write(x + " ");
            }
        }
        FillArray();
        PrintArray();
        }
    }
}
