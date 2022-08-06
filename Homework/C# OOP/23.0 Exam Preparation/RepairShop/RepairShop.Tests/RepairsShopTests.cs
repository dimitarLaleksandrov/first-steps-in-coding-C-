using NUnit.Framework;
using System;

namespace RepairShop.Tests
{
    public class Tests
    {
        public class RepairsShopTests
        {
            [Test]
            public void GarageNameShudTrowExeption()
            {
                Assert.Throws<ArgumentNullException>(() =>
                {
                    var garage = new Garage(null, 10);
                },
                 "Invalid garage name.");
                Assert.Throws<ArgumentNullException>(() =>
                {
                    var garage = new Garage(String.Empty, 10);
                },
                 "Invalid garage name.");
            }
            [Test]
            public void GarageNameProBTest()
            {
                var garage = new Garage("test", 10);
                Assert.That(garage.Name, Is.EqualTo("test"));
            }
            [Test]
            public void GarageMechanicsAvailableSgudThrowArgumentException()
            {
                Assert.Throws<ArgumentNullException>(() =>
                {
                    var garage = new Garage(String.Empty, 0);
                },
                 "At least one mechanic must work in the garage.");
                Assert.Throws<ArgumentNullException>(() =>
                {
                    var garage = new Garage(String.Empty, -1);
                },
                 "At least one mechanic must work in the garage.");
                Assert.Throws<ArgumentNullException>(() =>
                {
                    var garage = new Garage(String.Empty, -10);
                },
                 "At least one mechanic must work in the garage.");
            }
            [Test]
            public void GrageMechanicsAvailableSgudBeAdded()
            {
                const int garageMehaniks = 10;
                var garage = new Garage("test", garageMehaniks);
                Assert.That(garage.MechanicsAvailable, Is.EqualTo(garageMehaniks));
            }
            [Test]
            public void GarageAddCarShudThrowInvalidOperationException()
            {
                var car = new Car("Reno", 5);
                var secondCar = new Car("Pejo", 3);
                var therdCar = new Car("Tesla", 10);
                var garage = new Garage("test", 2);
                garage.AddCar(car);
                garage.AddCar(secondCar);
                Assert.Throws<InvalidOperationException>(() =>
                {
                    garage.AddCar(therdCar);
                },
                "No mechanic available.");
            }
            [Test]
            public void GarageShudAddCarShouldIncrementCarCounte()
            {
                var car = new Car("Reno", 5);
                var secondCar = new Car("Pejo", 3);
                var therdCar = new Car("Tesla", 10);
                var garage = new Garage("test", 4);
                garage.AddCar(car);
                garage.AddCar(secondCar);
                garage.AddCar(therdCar);
                Assert.That(garage.CarsInGarage, Is.EqualTo(3));
            }
            [Test]
            public void GarageFixCarShoudThrowInvalidOperationExceptionIfcarModelDontExist()
            {
                var car = new Car("Reno", 5);
                var secondCar = new Car("Pejo", 3);
                var therdCar = new Car("Tesla", 10);
                var garage = new Garage("test", 4);
                Assert.Throws<InvalidOperationException>(() => 
                {
                    garage.FixCar("Opel");
                },
                $"The car Opel doesn't exist.");
            }
            [Test]
            public void GaregeFIxCarShudreturnCar()
            {
                var car = new Car("Reno", 5);
                var secondCar = new Car("Pejo", 3);
                var therdCar = new Car("Tesla", 10);
                var garage = new Garage("test", 4);
                garage.AddCar(car);
                var fixedCar = garage.FixCar("Reno");
                Assert.That(fixedCar.IsFixed, Is.True);
                Assert.That(fixedCar.CarModel, Is.EqualTo("Reno"));
                Assert.That(fixedCar.NumberOfIssues, Is.EqualTo(0));
            }
            [Test]
            public void GarageRemoveFixedCarShoudThrowInvalidOperationException()
            {
                var car = new Car("Reno", 5);
                var secondCar = new Car("Pejo", 3);
                var therdCar = new Car("Tesla", 10);
                var garage = new Garage("test", 4);
                Assert.Throws<InvalidOperationException>(() =>
                {
                    garage.RemoveFixedCar();
                },
                $"The car Opel doesn't exist.");
            }
            [Test]
            public void GarageFixedCarsShudRemoveFixedCars()
            {
                var car = new Car("Reno", 5);
                var secondCar = new Car("Pejo", 3);
                var therdCar = new Car("Tesla", 10);
                var garage = new Garage("test", 4);
                garage.AddCar(car);
                garage.AddCar(secondCar);
                garage.AddCar(therdCar);
                garage.FixCar("Reno");
                var fixedCar = garage.RemoveFixedCar();
                Assert.That(fixedCar, Is.EqualTo(1));
                Assert.That(garage.CarsInGarage, Is.EqualTo(2));
            }
            [Test]
            public void GarageReportForFixedCars()
            {
                var car = new Car("Reno", 5);
                var secondCar = new Car("Pejo", 3);
                var therdCar = new Car("Tesla", 10);
                var garage = new Garage("test", 4);
                garage.AddCar(car);
                garage.AddCar(secondCar);
                garage.AddCar(therdCar);
                garage.FixCar("Reno");
                var report = garage.Report();
                Assert.That(report, Is.EqualTo($"There are 2 which are not fixed: Pejo, Tesla."));
            }
        }
    }
}