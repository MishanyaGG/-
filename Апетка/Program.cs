using System;
using AptekaClass;
using System.Collections.Generic;

namespace Апетка
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Apteka> apt = new List<Apteka>();
            Console.WriteLine("Введите название аптеки");
            string name_apt = Console.ReadLine();
            Console.WriteLine("Введите количество лекарств в аптеке");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < n; x++)
            {
                Console.WriteLine("Введите название лекарства");
                string name_lec = Console.ReadLine();
                Console.WriteLine("Введите стоимость лекарства");
                float stoimost = float.Parse(Console.ReadLine());
                apt.Add(new Apteka(name_apt, name_lec, stoimost));
            }
            foreach(Apteka z in apt)
                z.Info();
        }
    }
}
