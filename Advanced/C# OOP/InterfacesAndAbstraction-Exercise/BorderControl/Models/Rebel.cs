using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorderControl.Models.Interfaces;

namespace BorderControl.Models
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; }

        public int Age { get; private set; }

        public string Group { get; private set; }

        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
