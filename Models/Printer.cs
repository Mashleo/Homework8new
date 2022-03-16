using System;

namespace Models
{
    public class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
