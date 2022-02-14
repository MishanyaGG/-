using System;

namespace Определить_в_каком_числе_больше_цифр
{
    class resh
    {
        public void Reshenie(int a, int b)
        {
            int new_a = a;
            int new_b = b;
            int n = 0;
            int k = 0;

            while (a > 0)
            {
                a = a / 10;
                n = n + 1;
            }
            while (b > 0)
            {
                b = b / 10;
                k = k + 1;
            }
            if (n > k)
                Console.WriteLine($"В числе {new_a} больше цифр, чем в {new_b}. Количество цифр {new_a} = {n}, {new_b} = {k}");
            else
            {
                if (n<k)
                    Console.WriteLine($"В числе {new_b} больше цифр, чем в {new_a}. Количество цифр {new_a} = {n}, {new_b} = {k}");
                else
                    Console.WriteLine($"В числах {new_a} и {new_b} одинаковое количество цифр");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Определение в каком числе больше цифр");
                resh snach = new resh();
                Console.WriteLine("Введите первое число");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введте второе число");
                int b = Convert.ToInt32(Console.ReadLine());
                snach.Reshenie(a, b);
            }
        }
    }
}
