namespace AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            
            while (true)
            {
                string rescource = Console.ReadLine();

                if (rescource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!materials.ContainsKey(rescource))
                {
                    materials.Add(rescource, quantity);
                }
                else
                {
                    materials[rescource] += quantity;
                }

            }

            foreach (var material in materials)
            {
                Console.WriteLine($"{material.Key} -> {material.Value}");
            }
        }
    }
}