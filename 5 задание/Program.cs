using System;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        Console.WriteLine("Массив 1");
        int[,] mas1 = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                mas1[i, j] = random.Next(1, 10);
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(mas1[i, j] + "\t");
            }           
            Console.WriteLine("\n");
        }

        Console.WriteLine("Массив 2");
        int[,] mas2 = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                mas2[i, j] = random.Next(1, 10);
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                mas2[i, j] = random.Next(1, 10);
                Console.Write(mas2[i,j] + "\t");
            }
            Console.WriteLine("\n");
        }

        Console.WriteLine("Перемноженная матрица");
        int[,] multmas = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                multmas[i, j] = 0;
                for (int k = 0; k <= 5 - 1; k++)
                {
                    multmas[i, j] += mas1[i, k] * mas2[k, j];
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(multmas[i, j] + "\t");
            }
            Console.WriteLine("\n");
        }
        Console.ReadKey();
    }
}