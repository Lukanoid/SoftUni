namespace Cars.Interfaces;

public interface IElectricCar : ICar
{
    public int Battery { get; set; }
}