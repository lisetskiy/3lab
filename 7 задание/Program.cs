using System;

namespace _7_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Программа работает с числами! \nПожалуйста введите число.");
                Console.Write("Введите номер члена ряда Фибоначчи: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Число ряда Фибоначчи: " + Fibonacci(number));
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Вы ввели не число!");
            }
        }    
        public static int Fibonacci(int number)
        {
            if (number == 0 | number == 1)
            {
                return 1;
            }                 
            return Fibonacci(number - 1) + Fibonacci(number - 2);  
        }
    }
}
