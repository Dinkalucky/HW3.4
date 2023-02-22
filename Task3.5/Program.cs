using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Назва книги:");
            new Title().Show();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Автор:");
            new Author().Show();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Зміст:");
            new Content().Show();

            Console.Read();
        }
    }
}
