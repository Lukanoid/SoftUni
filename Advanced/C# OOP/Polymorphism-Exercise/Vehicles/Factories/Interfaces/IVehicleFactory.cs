using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public interface IVehicleFactory
    {
        IDrivable Create(string type, double fuelQuantity, double fuelConsumption, double tankCapacity);
    }
}
