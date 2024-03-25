using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raiding.Models.Interfaces;

namespace BaseHero.Factories.Interfaces
{
    public interface IHeroFactory
    {
        IHero Create(string name, string type);
    }
}
