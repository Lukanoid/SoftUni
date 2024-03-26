namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            char[] separators = new[] { ' ', ',' };

            string[] cardArr = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < cardArr.Length; i+= 2)
            {
                try
                {
                    Card card = new Card(cardArr[i], cardArr[i + 1]);
                    cards.Add(card);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(string.Join(" ", cards));

        }
    }

    public class Card
    {
        private string face;
        private string suit;

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }


        public string Face
        {
            get
            {
                return face;
            }
            set
            {
                switch (value)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                    case "J":
                    case "Q":
                    case "K":
                    case "A":
                        face = value;
                        break;
                    default:
                        throw new ArgumentException("Invalid card!");
                }
            }
        }
        public string Suit
        {
            get
            {
                return suit;
            }
            set
            {
                if (value == "S" || value == "H" || value == "D" || value == "C")
                {
                    suit = value;
                }
                else
                {
                    throw new ArgumentException("Invalid card!");
                }
            }
        }

        public override string ToString()
        {
            string symbol = "";
            switch (suit)
            {
                case "S":
                    symbol = "♠";
                    break;
                case "H":
                    symbol = "♥";
                    break;
                case "D":
                    symbol = "♦";
                    break;
                case "C":
                    symbol = "♣";
                    break;
            }

            return $"[{face}{symbol}]";
        }
    }
}
