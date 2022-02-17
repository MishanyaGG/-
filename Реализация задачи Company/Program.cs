using System;

namespace Реализация_задачи_Company
{
    class Company
    {
        /// <summary>
        /// Название
        /// </summary>
        public string name;
        /// <summary>
        /// Количество сотрудников
        /// </summary>
        public int persons;
        /// <summary>
        /// Месячный фонд зарплаты
        /// </summary>
        //---------Описание методов--------
        ///
        public int money;

        /// <summary>
        /// 1. метод не возвращает значения
        /// и не имеет параметров;
        /// печать информации о компании
        /// </summary>
        public void show()
        {
            Console.WriteLine($"В компании {name} трудятся {persons} сотрудников");
            Console.WriteLine($"Фонд зарплаты {money}");
        }
        /// <summary>
        /// 2. Метод возвращает значение
        /// и не имеет параметров;
        /// вычисление средней зарплаыты сотрудников
        /// </summary>
        /// <returns>Средняя зарплата сотрудника</returns>
        public int averageSlary()
        {
            return money / persons;
        }
        /// <summary>
        /// 3. метод возращает значение
        /// и имеет один параметр;
        /// определение наибольшего количества
        /// сотрудников, которые могут работать
        /// в компании при заданной средней зарплате
        /// </summary>
        /// <param name="salary">Зарплата</param>
        /// <returns>Определение сотрудников, которые могут рабоать в компании</returns>
        public int maxPersons(int salary)
        {
            return money / salary;
        }
        /// <summary>
        /// 4. метод возвращает значение
        /// и имеет два параметра;
        /// определение суммы налога и
        /// отчисления в пенсионный фонд (ПФ)
        /// </summary>
        /// <param name="minus1"></param>
        /// <param name="minus2"></param>
        /// <returns></returns>
        public int minus(int minus1, int minus2)
        {
            return money * (minus1 + minus2) / 100;
        }
    } //конец описания класса Company

    class Program
    {
        public static void Main()
        {
            //создание и инициализация объекта
            Company factory = new Company();
            factory.name = "Премьер";
            factory.persons = 100;
            factory.money = 100000;
            //вызовы методов
            factory.show();
            Console.WriteLine($"Средняя зарплата {factory.averageSlary()}");
            Console.WriteLine($"Отчисления {factory.minus(13, 4)}");
            Console.WriteLine("Средняя зарплата?");
            int average = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество сотрудников {factory.maxPersons(average)}");
        }
    }
}
