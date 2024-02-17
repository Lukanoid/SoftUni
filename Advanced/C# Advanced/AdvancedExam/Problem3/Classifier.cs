using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
		private int capacity;
        private List<Shark> species;

        public Classifier(int capacity)
        {
            this.Capacity = capacity;
            this.species = new List<Shark>();
        }

        public int Capacity
		{
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
		}

        public List<Shark> Species
        {
            get
            {
                return species;
            }
            set
            {
                species = value;
            }
        }

        public int GetCount
        {
            get { return this.species.Count; }

        }

        public void AddShark(Shark shark)
        {
            if (this.Species.Count < Capacity)
            {
                if (!Species.Contains(shark))
                {
                    Species.Add(shark);
                }
            }
        }

        public bool RemoveShark(string kind)
        {
            Shark shark = Species.FirstOrDefault(x => x.Kind == kind);
            if (shark == null)
            {
                return false;

            }

            return this.Species.Remove(shark);
        }

        public string GetLargestShark()
        {
            Shark longestShark = null;

            foreach (var shark in Species)
            {
                if (longestShark == null)
                {
                    longestShark = shark;
                }

                if (shark.Length > longestShark.Length)
                {
                    longestShark = shark;
                }

            }

            return longestShark.ToString();
        }

        public double GetAverageLength()
        {
            return Species.Average(x => x.Length);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Species.Count} sharks classified:");
            foreach (var shark in Species)
            {
                sb.AppendLine(shark.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}