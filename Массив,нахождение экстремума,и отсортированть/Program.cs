using System;

namespace Массив_нахождение_экстремума_и_отсортированть
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Random rand = new Random();
            int min = int.MaxValue; //int.MaxValue = 2 147 483 647
            int max = int.MinValue; //int.MinValue = -2 147 483 647
            int index_min = 0;
            int index_max = 0;
            for (int x = 0; x < array.Length; x++)
            {
                array[x] = rand.Next(20); //Пока х меньше количество элементов массива, то х увелчивается на 1
                Console.Write(array[x] + " ");
            }
            Console.WriteLine("\nИндексы");
            for (int x = 0; x < array.Length; x++)
            {
                Console.WriteLine($"{x}-ый элемент массива равен {array[x]}");
                if (array[x] > max)
                {
                    max = array[x];
                    index_max = x;
                }
                if (array [x] <min)
                {
                    min = array[x];
                    index_min = x;
                }
            }

            Console.WriteLine("\n***********************************************************");
            Console.WriteLine($"Минимальное значение в массиве = {min}, максимальное значение в массиве = {max}");
            Console.WriteLine($"Разность, между максимальным и минимальным значением в массиве {Math.Abs(index_max - index_min)}");
            
            int vrem; //Временная переменная
            //BubbleSort
            for (int x = 0; x<array.Length; x++)
            {
                for (int j = x+1; j<array.Length; j++)
                {
                    if (array[x]>array[j])
                    {
                        vrem = array[x];
                        array[x] = array[j];
                        array[j] = vrem;
                    }
                }
            }
            Console.WriteLine("Соритровка массива");
            Console.WriteLine();
            for(int x = 0; x<array.Length;x++)
            {
                Console.Write(array[x] + " ");
            }
            Console.WriteLine("\n***********************************************************");
        }
    }
}
