namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            decimal biggestKegVolume = decimal.MinValue;
            string biggestKegName = "";


            for (int i = 0; i < numberOfKegs; i++)
            {
                string kegName = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                decimal volume = (decimal)Math.PI * (radius * radius) * height;

                if(volume > biggestKegVolume)
                {
                    biggestKegVolume = volume;
                    biggestKegName = kegName;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}