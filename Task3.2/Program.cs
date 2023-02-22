using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic handler;
            string documentFormat;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть формат документу");
            documentFormat = Console.ReadLine();
            if (documentFormat == "XML")
            {
                handler = new XMLHandler();
            }
            else if(documentFormat == "TXT")
            {
                handler = new TXTHandler();
            }
            else
            {
                handler = new DOCHandler();
            }

            handler.Create();
            handler.Open();
            handler.Change();
            handler.Save();
            Console.ReadLine();
        }
    }
}
