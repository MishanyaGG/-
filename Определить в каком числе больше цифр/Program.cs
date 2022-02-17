using System;

namespace Определить_в_каком_числе_больше_цифр
{
    class resh
    {
        public int count_a(int a)
        {
            int n = 0; //Переменная, которая будет определять количество цифр в первом числе
            while (Math.Abs(a) > 0)
            {
                a = a / 10;
                n++;
            }
            return n;
        }
        public int count_b(int b)
        {
            int k = 0; //Переменная, которая будет определять количество цифр во втором числе
            while (Math.Abs(b) > 0)
            {
                b = b / 10;
                k++;
            }
            return k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Определение в каком числе больше цифр");
           resh snach = new resh();
           Console.WriteLine("Введите первое число");
           int a = Convert.ToInt32(Console.ReadLine()); //Первое число
           Console.WriteLine("Введте второе число");
           int b = Convert.ToInt32(Console.ReadLine()); //Второе число
           int snach_a = a;
           int snach_b = b;


           if (snach.count_a(a) > snach.count_b(b))
               Console.WriteLine($"В числе {a} больше цифр, чем в {b}. Количество цифр {a} = {snach.count_a(a)}, {b} = {snach.count_b(b)}");
           else
           {
               if (snach.count_a(a) < snach.count_b(b))
                   Console.WriteLine($"В числе {b} больше цифр, чем в {a}. Количество цифр {a} = {snach.count_a(a)}, {b} = {snach.count_b(b)}");
               else
                   Console.WriteLine($"В числах {a} и {b} одинаковое количество цифр");
           }
        }
    }
    
}
