using System;
using AptekaClass;
using System.Collections.Generic;

namespace AptekaClass
{
    public class Apteka
    {
        public string name_apt;
        public string name_lec;
        public float stoimost;

        public Apteka(string name_apt, string name_lec, float stomiost)
        {
            name_apt = this.name_apt;
            name_lec = this.name_lec;
            stomiost= this.stoimost;
        }

        public void Info()
        {
            Console.WriteLine($"Название аптеки {name_apt}");
            Console.Write($"Название лекарства {name_lec}. Стоимость лекарства {stoimost}");
        }
        public void MaxPrice()
        {

        }
    }
}
