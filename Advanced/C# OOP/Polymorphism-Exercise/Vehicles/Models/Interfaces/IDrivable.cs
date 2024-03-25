using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public interface IDrivable
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }
        double TankCapacity { get; }

        public void Drive(double kilometers, bool isIncreaseConsumption);
        public void Refuel(double fuel);
    }
}
