using System;
using System.Linq;

namespace _1_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Программа работает с числами! \nПожалуйста введите число.");
                Random ran = new Random();
                Console.Write("Введите кол-во элементов массива: ");
                int value = Convert.ToInt32(Console.ReadLine());
                

                int[] mas = new int[value];
                Console.WriteLine("массив: ");
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = ran.Next(-30, 45);
                }
               
                for (int i = 0; i < mas.Length; i++)
                {
                    if (i % 10 == 0)
                    {
                        Console.WriteLine("\n");
                    }
                    Console.Write(mas[i] + "\t");
                }
                Console.WriteLine("\nЭлементы массива в обратном направлении без отрицательных чисел: ");
                mas = mas.Reverse().ToArray();
                int count = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] >= 0)
                    {
                        if (count % 10 == 0)
                        {
                            Console.WriteLine("\n");
                        }
                        Console.Write(mas[i] + "\t");
                        count++;
                    }
                    


                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Вы ввели не число!");
            }
        }
    }
}
