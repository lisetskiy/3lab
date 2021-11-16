using System;
   class Program
   {
      static void Main(string[] args)
      {
        Random random = new Random();
        // Первый массив 
        Console.WriteLine("1 массив:");
        int[,] mas1 = new int[3, 3];
        for (int i = 0; i < 3; i++)
         {
             for (int j = 0; j < 3; j++)
             {
               mas1[i, j] = random.Next(1,10);
              
             }
         }
         for (int i = 0; i < 3; i++)
         {
             for (int j = 0; j < 3; j++)
             {
                 Console.Write(mas1[i, j] + "\t");
             }
             Console.WriteLine();
             Console.WriteLine("\t");
         }
        // Второй массив
        Console.WriteLine("2  массив:");
        int[,] mas2 = new int[3, 3];
        for (int i = 0; i < 3; i++)
         {
             for (int j = 0; j < 3; j++)
             {
                 mas2[i, j] = random.Next(1,10);
             }
         }
         for (int i = 0; i < 3; i++)
         {
             for (int j = 0; j < 3; j++)
             {
                 Console.Write(mas2[i, j] + "\t");
             }
             Console.WriteLine();
             Console.WriteLine();
         }
         // Выбор действия
        Console.WriteLine("Выберите действие: " +
            "\n1) Сложение (+) " +
            "\n2) Вычитание (-) " +
            "\n3) Среднее значение (/)");
        Console.Write("Действие: ");
        int[,] res = new int[3, 3];
        bool flag = true;
        double[] resDiv = new double[2];
        switch (Console.ReadLine())
        {
            case "+":
                res = Sum(mas1, mas2);
                flag = true;
                break;
            case "-":
                res = Subtraction(mas1, mas2);
                flag = true;
                break;
            case "/":
                resDiv = Division(mas1, mas2);
                break;
        }
        if (flag)
        {
          Console.WriteLine("Результирующий массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(res[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Среднее значение:\nПервый массив = {0}\nВторой массив = {1}", resDiv[0], resDiv[1]);
        }
        Console.ReadKey();
      }
      static int[,] Sum(int[,] mas1, int[,] mas2)
      {
          int[,] res = new int[3, 3];
          for (int i = 0; i < 3; i++)
          {
              for (int j = 0; j < 3; j++)
              {
                res[i, j] = mas1[i, j] + mas2[i, j];
              }
          }
          return res;
      }
      static int[,] Subtraction(int[,] mas1, int[,] mas2)
      {
          int[,] res = new int[3, 3];
          for (int i = 0; i < 3; i++)
          {
              for (int j = 0; j < 3; j++)
              {
                res[i, j] = mas1[i, j] - mas2[i, j];
              }
          }
          return res;
      }
      static double[] Division(int[,] mas1, int[,] mas2)
      {
          double[] res = new double[2];
          double sum1 = 0;
          double sum2 = 0;
          for (int i = 0; i < 3; i++)
          {
              for (int j = 0; j < 3; j++)
              {
                  sum1 = sum1 + mas1[i, j];
              }
          }
        res[0] = sum1 / mas1.Length;
          for (int i = 0; i < 3; i++)
          {
              for (int j = 0; j < 3; j++)
              {
                  sum2 = sum2 + mas2[i, j];
              } 
          }
        res[1] = sum2 / mas2.Length;
          return res;  
      }
   }