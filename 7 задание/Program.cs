using System;

namespace _7_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер члена ряда Фибоначчи: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число ряда Фибоначчи: " + Fibonacci(number));
            Console.ReadKey();
        }
        static int Fibonacci(int number)
        {
            if (number == 0 || number == 1)
                return number;
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
