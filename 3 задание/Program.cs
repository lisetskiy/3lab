using System;

namespace _3_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Программа работает с числами! \nПожалуйста введите число.");
                Console.Write("Введите кол-во значений массива: "); int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите кол-во сдвигов влево: "); int count = Convert.ToInt32(Console.ReadLine());
                Random ran = new Random();
                int[] mas = new int[number];
                int[] mas1 = new int[number];

                Console.WriteLine("Вывод массива: ");

                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = i;
                    Console.Write(mas[i] + "\t");
                }

                Console.WriteLine();
                Console.WriteLine("Вывод сдвинутого массива: ");

                for (int i = 0; i < mas.Length; i++)
                {
                    mas1[i] = (i + count) % mas.Length;
                    Console.Write(mas1[i] + "\t");
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
