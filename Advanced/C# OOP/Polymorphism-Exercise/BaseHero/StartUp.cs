
using BaseHero.Core.Interfaces;
using BaseHero.Factories.Interfaces;
using BaseHero.IO;
using BaseHero.IO.Interfaces;
using Raiding.Core;
using VehiclesExtension.Factories;

namespace BaseHero
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IHeroFactory heroFactory = new HeroFactory();

            IEngine engine = new Engine(reader, writer, heroFactory);

            engine.Run();
        }
    }
}
