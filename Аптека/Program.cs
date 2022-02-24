using System;
using System.Collections.Generic;

namespace Аптека
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Apteka> apteka = new List<Apteka>();
            Console.WriteLine("Введите название аптеки");
            string name_apt = Console.ReadLine();
            Console.WriteLine("Введите количество лекарств");
            int col = Convert.ToInt32(Console.ReadLine());
            double max = double.MinValue;
            string name_max;
            double summ = 0;
            for (int x = 0; x < col; x++)
            {
                Console.WriteLine($"Введите {x + 1} лекарство");
                string name_lek = Console.ReadLine();
                Console.WriteLine($"Введите его цену");
                double stoimost = double.Parse(Console.ReadLine());
                apteka.Add(new Apteka(name_apt, name_lek, stoimost));
                if (max < stoimost)
                {
                    max = stoimost;
                    name_max = name_lek;
                    Console.WriteLine($"На данный момент максимальная стоимость: \nЛекарство {name_max} стоимость {max}");
                }
                summ = summ + stoimost;
            }
            Console.WriteLine($"Общая стоимость лекарств {summ}");
            Console.WriteLine("**********************************");
            Console.WriteLine($"Аптека {name_apt}");
            foreach (Apteka z in apteka)
                z.info();
        }
    }
}
