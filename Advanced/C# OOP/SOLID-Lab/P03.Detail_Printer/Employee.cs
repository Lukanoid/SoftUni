using System;
using P03.Detail_Printer;

namespace P03.DetailPrinter
{
    public class Employee : IEmployee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
