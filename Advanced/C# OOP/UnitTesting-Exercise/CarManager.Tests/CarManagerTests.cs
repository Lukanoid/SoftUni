namespace Tests;

using CarManager;
using NUnit.Framework;
using System;

[TestFixture]
public class CarTests
{
    private Car car;

    [SetUp]
    public void SetUp()
    {
        car = new Car("Honda", "Civic", 10, 100);
    }

    [Test]
    public void ConstructorShouldWorkCorrectly()
    {
        string expectedMake = "Honda";
        string expectedModel = "Civic";
        double expectedFuelConsumption = 10;
        double expectedFuelCapacity = 100;

        string actualMake = car.Make;
        string actualModel = car.Model;
        double actualFuelConsumption = car.FuelConsumption;
        double actualFuelCapacity = car.FuelCapacity;

        Assert.AreEqual(expectedMake, actualMake);
        Assert.AreEqual(expectedModel, actualModel);
        Assert.AreEqual(expectedFuelConsumption, actualFuelConsumption);
        Assert.AreEqual(expectedFuelCapacity, actualFuelCapacity);
    }

    [Test]
    public void CarShouldBeCreatedWith0FuelAmount()
    {
        Assert.AreEqual(0, car.FuelAmount);
    }

    [TestCase("")]
    [TestCase(null)]
    public void CarShouldThrowExceptionIfMakeIsNullOrEmpty(string make)
    {
        ArgumentException exception = Assert.Throws<ArgumentException>(() =>
        {
            car = new Car(make, "Civic", 10, 100);
        });

        Assert.AreEqual("Make cannot be null or empty!", exception.Message);
    }

    [TestCase("")]
    [TestCase(null)]
    public void CarShouldThrowExceptionIfModelIsNullOrEmpty(string model)
    {
        ArgumentException exception = Assert.Throws<ArgumentException>(() =>
        {
            car = new Car("Honda", model, 10, 100);
        });

        Assert.AreEqual("Model cannot be null or empty!", exception.Message);
    }

    [TestCase(0)]
    [TestCase(-15)]
    public void CarShouldThrowExceptionIfFuelConsumptionIsZeroOrNegative(double fuelConsumption)
    {
        ArgumentException exception = Assert.Throws<ArgumentException>(() =>
        {
            car = new Car("Honda", "Civic", fuelConsumption, 100);
        });

        Assert.AreEqual("Fuel consumption cannot be zero or negative!", exception.Message);
    }

    [TestCase(0)]
    [TestCase(-15)]
    public void CarShouldThrowExceptionIfFuelCapacityIsZeroOrNegative(double fuelCapacity)
    {
        ArgumentException exception = Assert.Throws<ArgumentException>(() =>
        {
            car = new Car("Honda", "Civic", 10, fuelCapacity);
        });

        Assert.AreEqual("Fuel capacity cannot be zero or negative!", exception.Message);
    }

    [Test]
    public void CarShouldThrowExceptionIfFuelAmountIsNegative()
    {
        Assert.Throws<InvalidOperationException>(()
            => car.Drive(12), "Fuel amount cannot be negative!");
    }

    [Test]
    public void CarShouldRefuelCorrectly()
    {
        car.Refuel(10);
        double expectedFuelAmount = 10;
        double actualFuelAmount = car.FuelAmount;

        Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
    }

    [TestCase(0)]
    [TestCase(-10)]
    public void CarShouldThrowExceptionIfRefuelAmountIsZeroOrNegative(double refuelAmount)
    {
        ArgumentException exception = Assert.Throws<ArgumentException>(() =>
        {
            car.Refuel(refuelAmount);
        });

        Assert.AreEqual("Fuel amount cannot be zero or negative!", exception.Message);
    }

    [Test]
    public void CarShouldRefuelToItsCapacityIfRefuelAmountIsMoreThanCapacityItself()
    {
        car.Refuel(200);
        double expectedAmount = 100;
        double actualAmount = car.FuelAmount;

        Assert.AreEqual(expectedAmount, actualAmount);
    }

    [Test]
    public void CarDriveMethodShouldWorkCorrectly()
    {
        car.Refuel(10);
        car.Drive(50);
        double expectedAmount = 5;
        double actualAmount = car.FuelAmount;

        Assert.AreEqual(expectedAmount, actualAmount);
    }

    [Test]
    public void CarDriveMethodShouldThrowExceptionIfAmountIsNotEnough()
    {
        car.Refuel(10);
        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() =>
        {
            car.Drive(200);
        });

        Assert.AreEqual("You don't have enough fuel to drive!",exception.Message);
    }
}