using System;
using System.Linq;

namespace _1_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Console.Write("Введите кол-во элементов массива: ");
            int value = int.Parse(Console.ReadLine());
            int[] mas = new int[value];
            Console.WriteLine("массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = ran.Next(-30, 45);
                Console.Write(mas[i] + "\t");
            }
            Console.WriteLine("\nЭлементы массива в обратном направлении без отрицательных чисел: ");
            mas = mas.Reverse().ToArray();
            for (int i = 0;i < mas.Length; i++)
            {
                if (mas[i] >= 0)
                {
                    Console.Write(mas[i] + "\t");
                }
            }
            Console.ReadKey();
        }
    }
}
