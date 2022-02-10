using System;

namespace Передача_параметров_приложению_в_консоли
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string imya = Console.ReadLine();
            Console.WriteLine($"Привет {imya}");
        }
    }
}
