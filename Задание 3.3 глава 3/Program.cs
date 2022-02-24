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

        public Sdanie(int col_et, int ploshad, int col_man)
        {
            this.col_et = col_et;
            this.ploshad = ploshad;
            this.col_man = col_man;

        }
        public void info (int col_et, int ploshad, int col_man)
        {
            Console.WriteLine($"{col_et} этажное здание, площадью {ploshad}, колчисетво проживающих {col_man}");
        }
        public int areapersons(int ploshad, int man)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Sdanie> sdanie = new List<Sdanie>();
        }
    }
}
