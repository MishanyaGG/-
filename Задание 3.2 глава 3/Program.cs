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

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Gaseta> gaseta = new List<Gaseta>();
            Console.WriteLine("Сколько газет вы хотите добавить в коллекцию");
            int i = Convert.ToInt32(Console.ReadLine());
            int por_nom = 0;
            if (i>0) //Проверка на завершение программы
            {
                for(int x =0; x<i; x++) //Введение информации в массив gaseta
                {
                    por_nom++;
                    Console.WriteLine("Введите название газеты");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите номер тиража");
                    int tirash = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Количесвто полос в газете");
                    int colich_pol = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Номер газеты {por_nom}) ");
                    gaseta.Add(new Gaseta(name, tirash, colich_pol));
                    foreach (Gaseta z in gaseta) //реализация методов Gaseta через переменную z
                        z.info();
                }
                Console.WriteLine("Хотите ли вы изменить название какой-нибудь газеты? 1-да, 0 - нет");
                i = Convert.ToInt32(Console.ReadLine());
                while (i == 1) //Проверка на изменение названия газет
                {
                    Console.WriteLine("У какой газеты вы хотите изменить название? Введите номер газеты");
                    por_nom = Convert.ToInt32(Console.ReadLine());
                    gaseta.RemoveAt(por_nom - 1); //Удалаяет элемент из массива gaseta
                    Console.WriteLine("Введите новое название газеты. Тираж и количество полей введите повторно. \n 1) Имя газеты \n 2) Номер тиража \n 3) Количество полос в газете");
                    gaseta.Insert(por_nom - 1, new Gaseta(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()))); //создание нового элемента в массиве gaseta
                    Console.WriteLine("У какой-то ещё газеты вы хотите изменить название? 1 - да, 0 - нет");
                    i = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Хотители вы изменить количество полос в какой-нибудь газете? 1 - да, 0 - нет");
                i = Convert.ToInt32(Console.ReadLine());
                while (i == 1) //Проверка на изменение количества полос в газете
                {
                    Console.WriteLine("У какой газеты вы хотите изменить название? Введите номер газеты");
                    por_nom = Convert.ToInt32(Console.ReadLine());
                    gaseta.RemoveAt(por_nom - 1);
                    Console.WriteLine("Введите новое количество полос в газете. Название и тираж введите повторно. \n 1) Имя газеты \n 2) Номер тиража \n 3) Количество полос в газете");
                    gaseta.Insert(por_nom - 1, new Gaseta(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                    Console.WriteLine("У какой-то ещё газеты вы хотите изменить название? 1 - да, 0 - нет");
                    i = Convert.ToInt32(Console.ReadLine());
                }
                foreach (Gaseta z in gaseta)
                    z.info();
                Console.WriteLine("Программа завершена");
            }
            else
                Console.WriteLine("Программа завершена");
        }
    }
}
