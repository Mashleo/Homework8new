using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Room
    {
        public Printer printerInRoom { get; set; }

        public void MakeThisLazyPrinterWork(string value)
        {
            printerInRoom.Print(value);
        }

        public void ReplacePrinter(Printer inputPrinter)
        {
            printerInRoom = inputPrinter;
        }
    }
}
