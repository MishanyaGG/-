using System;
using AptekaClass;
using System.Collections.Generic;

namespace AptekaClass
{
    public class Apteka
    {

        public void Info(string Name_lec, int Stoimost)
        {
            //Console.WriteLine($"Название аптеки {Name_apt}");
            Console.WriteLine($"Название лекарства {Name_lec}. Стоимость лекарства {Stoimost}");
        }
        public int All_Price (int price, int all_price)
        {
            return price + all_price;
        }
    }
    
}
