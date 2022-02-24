using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Аптека
{
    class Apteka
    {
        public string name_apt;
        public string name_lek;
        public double stoimost;

        public Apteka(string name_apt, string name_lek, double stoimost)
        {
            this.name_apt = name_apt;
            this.name_lek = name_lek;
            this.stoimost = stoimost;
        }

        public void info()
        {
            Console.WriteLine($"Название лекарства, его цена \n{name_lek} {stoimost}");
        }
    }
}
