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
            string name_apt1 = Console.ReadLine();
            
            Console.WriteLine("Введите количество лекарств");
            int col = Convert.ToInt32(Console.ReadLine());
            double summ = 0;
            Console.WriteLine($"Введите название  лекарство");
            string name_lek = Console.ReadLine();
            Console.WriteLine("Введите цену лекарства");
            int stoimost = int.Parse(Console.ReadLine());
            Apteka name_apt = new Apteka(name_apt1, name_lek, stoimost);
            //for (int x = 0; x < col; x++)
            //{
            //    Create_lec(name_apt, name_lek, stoimost);

            //}
            Console.WriteLine($"Общая стоимость лекарств {summ}");
            Console.WriteLine("**********************************");
            name_apt.Info();
            Console.ReadKey();
        }

        private static void Create_lec(Apteka apteka, string _lec_name, int x)
        {
            
            apteka.Add_Lek(_lec_name, x);
        }
    }
}
