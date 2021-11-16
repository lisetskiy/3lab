using System;

namespace _10_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во элементов массива: ");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
           
            int[] mas = new int[value];
            int minnumber = mas[0];
            Random ran = new Random();

            for(int i = 0; i < value; i++)
            {
                mas[i] = ran.Next(-100, 100);
                Console.Write(mas[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            
            for (int i = 1 ; i < mas.Length; i++)
            {
                if (mas[i] < minnumber)
                {
                    minnumber = mas[i];
                }
            }
            Console.WriteLine("Минимальное значение: " + minnumber);
            Console.ReadKey();
        }
    }
}
