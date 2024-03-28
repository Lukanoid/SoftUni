using System;
using System.Collections.Generic;
using P03.Detail_Printer;

namespace P03.DetailPrinter
{
    public class Manager : Employee , IManager
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(string.Join(Environment.NewLine, Documents));
        }
    }
}
