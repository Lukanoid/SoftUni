using BorderControl.Models.Interfaces;

namespace BorderControl.Models
{
    public class Robots : IIdentifiable
    {
        public Robots(string id, string model)
        {
            Id = id;
            Model = model;
        }
        public string Id { get; }

        public string Model { get; private set; }
    }
}
