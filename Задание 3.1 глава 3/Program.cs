using System;
using System.Collections.Generic;

namespace Задание_3._1_глава_3 //Машина
{
    class Car
    {
        /// <summary>
        /// Марка машины
        /// </summary>
        public string marka;    
        /// <summary>
        /// Модель машины
        /// </summary>
        public int nomer;
        /// <summary>
        /// Номер машины
        /// </summary>
        public string model;

        /// <summary>
        /// Конструкция
        /// </summary>
        /// <param name="marka">Марка машин</param>
        /// <param name="nomer">Номер машниы</param>
        /// <param name="model">Модель машниы</param>
        public  Car(string marka, int nomer, string model)
        {
            this.marka = marka;
            this.nomer = nomer;
            this.model = model;
        }
        /// <summary>
        /// Машина завелась
        /// </summary>
        /// <param name="marka">Марка машина</param>
        /// <param name="nomer">Номер машины</param>
        /// <param name="model">Модель машины</param>
        public void start()
        {
            Console.WriteLine($"Машина {marka} {model} {nomer} завелась");
        }
        /// <summary>
        /// Машина остановилась
        /// </summary>
        public void stop()
        {
            Console.WriteLine($"Машина {marka} {model} {nomer} остановилась");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> car = new List<Car>(); //Объявлении коллекции
            Console.WriteLine("Сколько машин будем заносить в коллекцию?");
            int i = Convert.ToInt32(Console.ReadLine());
            int por_nom= 0;
            if (i > 0) //Проверка количество заносящихся машин
            {
                for (int x = 0; x < i; x++) //Добавление машин
                {
                    por_nom++;
                    Console.Write("Введите марку машины");
                    string marka = Console.ReadLine();
                    Console.Write("Введите номер машины");
                    int nomer = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите модель машины");
                    string model = Console.ReadLine();
                    car.Add(new Car(marka, nomer, model));
                    Console.WriteLine($"{por_nom}. {marka} {model} {nomer}");  
                }
                foreach(Car z in car)
                {
                    z.start();
                    z.stop();
                }
            }
            else
                Console.WriteLine("Конец программы");
        }
    }
}
