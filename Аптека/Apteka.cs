using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Аптека
{
    class Apteka
    {
        private string name_apt;
        public SortedList<string, int> name_lek;

        public Apteka(string name_apt)
        {
            this.name_apt = name_apt;
        }
        public Apteka(string name_apt, string name_lek, int price)
        {

        }
        public void Add_Lek(string _name_lek, int price = 0)
        {
            name_lek.Add(_name_lek, price);
        }


        public void Info()
        {
            Console.WriteLine($"Список лекарств аптеки {this.name_apt}: ");
            Console.WriteLine(this.name_lek);
        }

        /*public void MaxPrice(string name_apt,  List<Apteka> apteka)
        {
            apteka = apteka.OrderBy(x => x.stoimost).ThenBy(y => y.name_lek).ToList();
            int size = apteka.Count();
            Console.WriteLine($"Самое дорогое лекарство{name_lek[size-1]} стоит {stoimost}");
        }*/
    }
}
