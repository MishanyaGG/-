using System;
using System.Collections.Generic;

namespace Реализация_задачи_Company
{
    /*class Company
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
        //public int money;
        //---------Описание методов--------
        

        public Company (string name, int persons, int money)
        {
            this.name = name;
            this.persons = persons;
            this.money = money;
        }
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
    } //конец описания класса Company*/

    /// <summary>
    /// Реализация Company через массив
    /// </summary>
    /*class MasCompany
    {
        public static void Main()
        {
            int i;
            Company[] CityCompany = new Company[2];
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Информация о компании: \n 1) Название компании\n 2)Количество сотрудников\n 3)Месячный фонд компании");
                CityCompany[i] = new Company(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            for (i = 0; i < 2; i++)
            {
                CityCompany[i].show();
                Console.WriteLine($"Средняя зарплата {CityCompany[i].averageSlary()}");
                Console.WriteLine("Введите зарплату");
                int salary = int.Parse(Console.ReadLine());
                Console.WriteLine($"Количество сотрудников, которые могут работать в компании {CityCompany[i].maxPersons(salary)}");
                Console.WriteLine($"Отчисления {CityCompany[i].minus(13, 4)}");
            }
        }
    }*/
    /// <summary>
    /// Реализация Company через list
    /// </summary>
    /*class Program
    {
        public static void Main()
        {
            List<Company> comp1 = new List<Company>();
            Console.WriteLine("Введите количество заполняемых компаний");
            int i = int.Parse(Console.ReadLine());
            int nomer = 0;
            for (int x=0; x<i; x++)
            {
                nomer++;
                Console.WriteLine($"Номмер компании {nomer} \nИнформация о компании: \n 1) Название компании\n 2) Количество сотрудников\n 3)Месячный фонд компании ");
                comp1.Add(new Company(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            }
            Console.WriteLine("Исходня коллекция");
            foreach (Company z in comp1)
                z.show();
            Console.WriteLine("Хотите ли вы отредактировать какую-нибудь компанию? 1-да, 0-нет");
            int remove = int.Parse(Console.ReadLine());
            if (remove == 1)
            {
                Console.WriteLine("Какую компанию вы хотите изменить? Введите номер компании");
                nomer = int.Parse(Console.ReadLine());
                //метод Remove удаляет элемент по ссылке
                comp1.Remove(comp1[nomer-1]);
                Console.WriteLine("Введите новые данные. \n 1) Название компании\n 2) Количество сотрудников\n 3)Месячный фонд компании");
                //вставка объекта по указанному индексу
                //(сдвиг вправо)
                comp1.Insert(nomer-1, new Company(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            }*/
    /*метод RemoveAt удаляет элемент по индексу
    comp1.RemoveAt(0);
    Console.WriteLine("*****************************");
    Console.WriteLine("Преобразованная коллекция");
    foreach (Company z in comp1)
        z.show();
}
}*/
    /*реализация свойств
     */
    /*class Company
    {
        string name; //название
        int persons; //количество сотрудников
        int money; //месячный фонд зарплаты
        public string Name
        {
            get //Свойство
            {
                return name;
            }
            set
            {
                if (name == null)
                    name = value;
            }
        }
        public int Persons
        {
            get //свойство
            {
                return persons;
            }
            set
            {
                persons = value;
            }
        }
        
        /// <summary>
        /// метод
        /// </summary>
        public Company()
        {
            persons = 10000; //конструктор
        }
    }*/
    /*class Program
    {
        public static void Main()
        {
            Company comp1 = new Company();
            //вызывается аксессор set
            //свойства Name - из контекста
            comp1.Name = "АБВГД";
            //вызывается аксессор get
            //свойства Name - из контекста
            Console.Write($"В компании {comp1.Name} ");
            //вызывается аксессор get свойста Persons
            Console.WriteLine($"Трудятся {comp1.Persons} сотрудников");
            //повторное изменение названия компании
            //название компании не измениться
            comp1.Name = "КЛМН";
            //вызывется аксессор set
            //свойства Persons 
            comp1.Persons += 10;
            Console.WriteLine($"В компании {comp1.Name} трудятся {comp1.Persons} сотрудников");
        }
    }*/
}
