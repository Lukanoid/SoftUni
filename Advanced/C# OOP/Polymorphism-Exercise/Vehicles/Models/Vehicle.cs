using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle : IDrivable
    {
        private double fuelConsumptionIncrease;
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption,double tankCapacity, double fuelConsumptionIncrease)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            this.fuelConsumptionIncrease = fuelConsumptionIncrease;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            private set
            {
                if (value > TankCapacity)
                {
                    value = 0;
                }
                fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get => fuelConsumption;
            private set
            {
                fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get => tankCapacity;
            private set
            {
                tankCapacity = value;
            }
        }


        public void Drive(double kilometers, bool isIncreaseConsumption)
        {
            double totalConsumption = 0;
            if (isIncreaseConsumption)
            {
                totalConsumption = (FuelConsumption + fuelConsumptionIncrease) * kilometers;
            }
            else
            {
                totalConsumption = FuelConsumption * kilometers;
            }

            if (FuelQuantity - totalConsumption >= 0)
            {
                FuelQuantity -= totalConsumption;
                Console.WriteLine($"{GetType().Name} travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel > tankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
