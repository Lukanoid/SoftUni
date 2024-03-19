using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models.Interfaces
{
    public interface IBuyer : INameable
    {
        public int Food { get; set; }
        public void BuyFood();
    }
}
