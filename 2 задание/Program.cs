using System;

namespace _2_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[7, 7];
            Random ran = new Random();
            //ввод массива рандомными числами и его вывод
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    mas[i, j] = ran.Next(100);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            //поворот массива 
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < Math.Floor(Convert.ToDouble(7) / 2); i++)
                {
                    for (int j = 0; j < Math.Ceiling(Convert.ToDouble(7) / 2); j++)
                    {
                        int rotate = mas[i, j];
                        mas[i, j] = mas[j, 7 - 1 - i];
                        mas[j, 7 - 1 - i] = mas[7 - 1 - i, 7 - 1 - j];
                        mas[7 - 1 - i, 7 - 1 - j] = mas[7 - 1 - j, i];
                        mas[7 - 1 - j, i] = rotate;
                    }
                }
            }
            //вывод повернутого массива
            Console.WriteLine("Повернутый массив:");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
