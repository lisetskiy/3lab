using System;

namespace _6_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            Console.WriteLine("Массив:");
            int[] mas = new int[value];
            for (int i = 0; i < value; i++)
            {
                mas[i] = random.Next(1,10);
            }
            
            for (int i = 0; i < value; i++)
            {
                Console.Write(mas[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("sumIterative:" + "\t" + sumIterative(mas));
            Console.WriteLine("sumRecursive:" + "\t" + sumRecursive(mas));
            Console.WriteLine("minIterative:" + "\t" + minIterative(mas));
            Console.WriteLine("minRecursive:" + "\t" + minRecursive(mas, mas[0]));
            Console.ReadKey();
        }
        static int sumIterative(int[] mas)
        {
            int res = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                res = res + mas[i];
            }
            return res;
        }
        static int sumRecursive(int[] mas)
        {
            if (mas.Length == 0)
            {
                return 0;
            }
            return mas[0] + sumRecursive(mas[1..]);
        }
        static int minIterative(int[] mas)
        {
            int min = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (min > mas[i])
                    min = mas[i];
            }
            return min;
        }
        static int minRecursive(int[] mas, int min)
        {
            if (mas.Length == 0)
            {
                return min;
            }
            if (min > mas[0])
            {
                min = mas[0];
            }
            return minRecursive(mas[1..], min);
        }
    }
}
