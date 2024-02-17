namespace Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfClothes = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfClothes; i++)
            {
                string[] currentClothes = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = currentClothes[0];
                string[] clothes = currentClothes[1].Split(',',StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                    foreach (var clothe in clothes)
                    {
                        if (!wardrobe[color].ContainsKey(clothe))
                        {
                            wardrobe[color].Add(clothe, 0);
                        }

                        wardrobe[color][clothe]++;
                    }
                }
                else
                {
                    foreach (var clothe in clothes)
                    {
                        if (!wardrobe[color].ContainsKey(clothe))
                        {
                            wardrobe[color].Add(clothe, 0);
                        }

                        wardrobe[color][clothe]++;
                    }
                }
            }

            string[] serchedClothe = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string currentColor = serchedClothe[0];
            string currentClothe = serchedClothe[1];

            foreach (var clothing in wardrobe)
            {
                Console.WriteLine(clothing.Key + " clothes:");
                foreach (var clothe in clothing.Value)
                {
                    if (clothing.Key == currentColor && clothe.Key == currentClothe)
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                    }
                }
            }
        }
    }
}
