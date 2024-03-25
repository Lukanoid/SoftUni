
namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double FuelConsumptionIncrease = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity, FuelConsumptionIncrease)
        {

        }
    }
}
