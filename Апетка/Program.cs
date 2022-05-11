using System;
using System.Collections.Generic;
using AptekaClass;

namespace Апетка
{
    class Program
    {
        static void Main(string[] args)
        {
            Apteka apt = new Apteka();
            Console.WriteLine("Введите название аптеки");
            string name_apt = Console.ReadLine();
            Console.WriteLine("Введите количество лекарств в аптеке");
            int all_price = 0;
            int price = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            string[] name = new string[n];
            int[] stoimost = new int[n];
            int max = int.MinValue;
            int max_index = 0;
            for (int x = 0; x<n; x++)
            {
                Console.WriteLine($"Введите название лекартсва");
                name[x] = Console.ReadLine();
                Console.WriteLine($"Введите цену {name[x]}");
                stoimost[x] = Convert.ToInt32(Console.ReadLine());
                if (stoimost[x] > max)
                {
                    max_index = x;
                    max = stoimost[x];
                }
            }
            Console.WriteLine($"Самое дорогое лекарство {name[max_index]} - {max}");
            Console.WriteLine($"Название аптеки {name_apt}");
            for (int x = 0; x<n; x++)
            {
                apt.Info(name[x], stoimost[x]);
                price = stoimost[x];
                all_price = apt.All_Price(price, all_price);
            }
            Console.WriteLine($"Сумма всех лекарств равна {all_price}");
        }
    }
}
