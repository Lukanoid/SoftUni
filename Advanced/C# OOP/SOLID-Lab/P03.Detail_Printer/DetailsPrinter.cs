using System;
using System.Collections.Generic;
using P03.Detail_Printer;

namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private IReadOnlyCollection<Employee> employees;

        public DetailsPrinter(IReadOnlyCollection<Employee> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails(Employee employee)
        {
            employee.Print();
        }

    }
}
