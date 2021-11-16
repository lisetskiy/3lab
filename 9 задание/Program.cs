using System;

namespace _9_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[5, 5];
            Random ran = new Random();

			Console.WriteLine("Вывод матрицы");
			for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mas[i, j] = ran.Next(1, 10);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

			int sum = 0;
			for (int i = 0; i < 5; i++)
			{
				sum = 0;				
				for (int j = 0; j < 5; j++)
				{                 
                    sum += mas[i, j] + mas[ i, j ];
				}			
				mas[i, i] = sum - mas[i, i];
			}

			Console.WriteLine("Вывод посчитанной матрицы");
			//Выводим новую матрицу на экран
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					Console.Write(mas[i, j] + " \t");
				}

				Console.WriteLine();
				Console.WriteLine();
			}
			Console.ReadLine();
			Console.ReadKey();
        }
    }
}
