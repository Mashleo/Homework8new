using System;
using Models;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("какой текст вы хотите напечатать :");
                string text = Console.ReadLine();
                Room room = new Room();
            

                room.ReplacePrinter(new GreenPrinter());
                room.MakeThisLazyPrinterWork(text);
                room.ReplacePrinter(new BluePrinter());
                room.MakeThisLazyPrinterWork(text);

            
        }
    }
}
