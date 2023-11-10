namespace StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] receivedData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string serailNumber = receivedData[0];
                string itemName = receivedData[1];
                int itemQuantity = int.Parse(receivedData[2]);
                decimal itemPrice = decimal.Parse(receivedData[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice
                };

                Box box = new Box()
                {
                    SerialNumber = serailNumber,
                    Item = item,
                    ItemQuantity = itemQuantity,
                    PriceForBox = itemQuantity * itemPrice
                };

                boxes.Add(box);

                input = Console.ReadLine();
            }

            foreach (var box in boxes.OrderByDescending(x => x.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }

    /// <summary>
    /// {boxSerialNumber}
    /// 
    /// -- {boxItemName} – ${boxItemPrice}: {boxItemQuantity}
    /// 
    /// -- ${boxPrice}
    /// </summary>

    public class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForBox { get; set; }

    }
}