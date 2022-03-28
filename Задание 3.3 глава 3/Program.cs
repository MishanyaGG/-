using System;
using System.Collections.Generic;

namespace Задание_3._3_глава_3
{
    class Sdanie
    {
        /// <summary>
        /// Количество этажей в здании
        /// </summary>
        public int col_et;
        /// <summary>
        /// Площадь
        /// </summary>
        public int ploshad;
        /// <summary>
        /// Количество жильцов
        /// </summary>
        public int col_man;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="col_et">Количество этажей</param>
        /// <param name="ploshad">Площадь здания</param>
        /// <param name="col_man">Количество жильцов</param>
        public Sdanie(int col_et, int ploshad, int col_man)
        {
            this.col_et = col_et;
            this.ploshad = ploshad;
            this.col_man = col_man;

        }
        /// <summary>
        /// Полная информация о здании
        /// </summary>
        /// <param name="col_et">Количество этажей</param>
        /// <param name="ploshad">Площадь здания</param>
        /// <param name="col_man">Количество жильцов</param>
        public void info (int col_et, double ploshad, int col_man)
        {
            Console.WriteLine($"{col_et} этажное здание, площадью {ploshad}, колчисетво проживающих {col_man}");
        }
        /// <summary>
        /// Вычисление площади на одного человека
        /// </summary>
        /// <param name="ploshad"></param>
        /// <param name="man"></param>
        /// <returns></returns>
        public double areapersons(double ploshad, int man)
        {
            return ploshad / man;
        }
        /// <summary>
        /// Вычисление максимально возможного количества человек в здании, если на каждого приходится заданная минимальная площадь
        /// </summary>
        /// <param name="ploshad"></param>
        /// <param name="man"></param>
        /// <returns></returns>
        public int MaxPersons(double ploshad, int man)
        {
            int count_man = 0;
            while (areapersons(ploshad, man) > ploshad)
                count_man++;
            return count_man;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Sdanie> sdanie = new List<Sdanie>();
            Console.WriteLine("Введите количество зданий");
            int count_sd = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x<count_sd; x++)
            {
                Console.WriteLine($"Введите количество этажей {x+1} здания");
                int count_et = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите площадь {x+1} здания");
                int ploshad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите количество жильцов в {x+1} здании");
                int count_man = Convert.ToInt32(Console.ReadLine());
                sdanie.Add(new Sdanie(count_et, ploshad, count_man));
            }
        }
    }
}
