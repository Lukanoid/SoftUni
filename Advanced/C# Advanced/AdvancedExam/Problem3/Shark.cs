using System.Text;

namespace SharkTaxonomy
{
    public class Shark
    {
		private string kind;
        private int length;
        private string food;
        private string habitat;

        public Shark(string kind, int length, string food, string habitat)
        {
            this.Kind = kind;
            this.Length = length;
            this.Food = food;
            this.Habitat = habitat;
        }
        public string Kind
		{
            get
            {
                return kind;
            }
            set
            {
                kind = value;
            }
		}

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public string Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
            }
        }

        public string Habitat
        {
            get
            {
                return habitat;
            }
            set
            {
                habitat = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Kind} shark: {this.Length}m long.");
            sb.AppendLine($"Could be spotted in the {this.Habitat}, typical menu: {this.Food}");
            return sb.ToString().TrimEnd();
        }
    }
}