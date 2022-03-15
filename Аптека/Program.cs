using System;
using System.Collections.Generic;

namespace Аптека
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите название аптеки");
            string name_apt = Console.ReadLine();
            Apteka apt = new Apteka(name_apt);
            Console.WriteLine("Введите количество лекарств");
            int col = Convert.ToInt32(Console.ReadLine());
            
            for (int x = 0; x < col; x++)
            {
                Console.WriteLine($"Введите название лекарство");
                string name_lek = Console.ReadLine();
                Console.WriteLine("Введите цену лекарства");
                int stoimost = int.Parse(Console.ReadLine());
                Create_lec(name_apt, name_lek, stoimost);
            }
            Console.WriteLine("**********************************");
            apt.Info();
            Console.ReadKey();
        }

        private static void Create_lec(string apteka, string _lec_name, int stoimist)
        {
            Apteka apt = new Apteka(apteka);
            apt.Add_Lek(_lec_name, stoimist);
        }
    }
}
