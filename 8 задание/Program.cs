using System;

namespace _8_задание
{
    class program
    {
        static void Main(string[] args)
        {        
            Console.Write("Введите размер матрицы :");
            int value = Convert.ToInt32(Console.ReadLine());

            if (value < 0)
            {
                Console.WriteLine("Введите значение больше 0");
            }

            double[,] mas = new double[value, value];                                                                
            Random ran = new Random();

            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    mas[i, j] = ran.Next(0, 10);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }           
            Console.WriteLine("Определитель матрицы: " + Determinantmatrix(mas));
            Console.ReadKey();
        }

        static double Determinantmatrix(double[,] mas)
        {
            if (mas.Length == 1)
                return mas[0, 0];
            if (mas.Length == 4)
                return mas[0, 0] * mas[1, 1] - mas[1, 0] * mas[0, 1];
            else
            {
                double res = 0;
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    //вычисление минора
                    double[,] M = Minor(mas, i);
                    res += Math.Pow(-1, i) * mas[0, i] * Determinantmatrix(M);
                }
                return res;
            }
        }

        static double[,] Minor(double[,] mas, int n)
        {
            double[,] result = new double[mas.GetLength(0) - 1, mas.GetLength(0) - 1];
            for (int i = 1; i < mas.GetLength(0); i++)
            {
                for (int j = 0, col = 0; j < mas.GetLength(1); j++)
                {
                    if (j == n)
                        continue;
                    result[i - 1, col] = mas[i, j];
                    col++;
                }
            }
            return result;
        }
    }
}