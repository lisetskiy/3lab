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
            Console.WriteLine();
            Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine("Перемноженная матрица");
        int[,] multmas = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                multmas[i, j] = mas1[i, j] * mas2[i, j];
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(multmas[i, j] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}