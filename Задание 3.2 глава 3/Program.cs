using System;
using System.Collections.Generic;

namespace Задание_3._2_глава_3 //Газета
{
    class Gaseta
    {
        /// <summary>
        /// Название газеты
        /// </summary>
        public string name;
        /// <summary>
        /// Номер тиража газеты
        /// </summary>
        public int tirash;
        /// <summary>
        /// Количество полос в газете
        /// </summary>
        public int colich_pol;
        /// <summary>
        /// Конструкция
        /// </summary>
        /// <param name="name">Название газеты</param>
        /// <param name="tirash">Номер тиража газеты</param>
        /// <param name="colich_pol">Количество строк в газете</param>
        public Gaseta(string name, int tirash, int colich_pol)
        {
            this.name = name;
            this.tirash = tirash;
            this.colich_pol = colich_pol;
        }
        /// <summary>
        /// Получение полной информации о газете
        /// </summary>
        public void info()
        {
            Console.WriteLine($"{name} №{tirash} количество строк в газете {colich_pol}");
        }
        /// <summary>
        /// Изменение названия газеты
        /// </summary>
        /// <returns>Новое название газеты</returns>
        public string ChangeName()
        {
            Console.WriteLine("Введите новое название газеты");
            string new_name = Console.ReadLine();
            return new_name;
        }
        /// <summary>
        /// Изменение количества строк в газете
        /// </summary>
        /// <returns>Новое количесто строк</returns>
        public int ChangeNumber()
        {
            Console.WriteLine("Введите новое количестов полос в газете");
            int new_colich_pol = Convert.ToInt32(Console.ReadLine());
            return new_colich_pol;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Gaseta> gasetee = new List<Gaseta>();
            Console.WriteLine("Сколько газет вы хотите добавить в коллекцию");
            int i = Convert.ToInt32(Console.ReadLine());
            int por_nom = 0;
            if (i>0)
            {
                for(int x =0; x<i; x++)
                {
                    por_nom++;
                    Console.WriteLine("Введите название газеты");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите номер тиража");
                    int tirash = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Количесвто полос в газете");
                    int colich_pol = Convert.ToInt32(Console.ReadLine());
                    Console.Write(por_nom + " ");
                    gasetee.Add(new Gaseta(name, tirash, colich_pol));
                    foreach (Gaseta z in gasetee)
                        z.info();
                }

            }
            else
                Console.WriteLine("Программа завершена");
        }
    }
}
