namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] data = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = data[0];
                string employeeId = data[1];

                if (!employees.ContainsKey(companyName))
                {
                    employees.Add(companyName, new List<string>());
                    employees[companyName].Add(employeeId);
                }
                else
                {
                    if (!employees[companyName].Contains(employeeId))
                    {
                        employees[companyName].Add(employeeId);
                    }
                }
            }

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Key);
                foreach (var human in employee.Value)
                {
                    Console.WriteLine($"-- {human}");
                }
            }
        }
    }
}