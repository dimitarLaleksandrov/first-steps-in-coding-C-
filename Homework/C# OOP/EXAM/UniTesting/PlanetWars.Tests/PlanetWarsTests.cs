using NUnit.Framework;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;

namespace PlanetWars.Tests
{
    public class Tests
    {
        [TestFixture]
        public class PlanetWarsTests
        {
            [TestCase("WindRoller", 10, 4)]
            public void TestWeaponConstruktorSet(string name, double price, int dlevel)
            {
                Weapon weapon = new Weapon(name, price, dlevel);
                Assert.AreEqual(weapon.Name, name);
                Assert.AreEqual(weapon.Price, price);
                Assert.AreEqual(weapon.DestructionLevel, dlevel);

            }
            [TestCase("WindRoller", -1, 4)]
            public void TestWeaponPriceSet(string name, double price, int dlevel)
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    Weapon weapon = new Weapon(name, price, dlevel);
                },
                "Price cannot be negative.");
            }
            [TestCase("WindRoller", 5, 2)]
            public void TestWeaponIncreaseDestructionLevel(string name, double price, int dlevel)
            {
                Weapon weapon = new Weapon(name, price, dlevel);
                weapon.IncreaseDestructionLevel();
                var expektedlevel = 3;
                Assert.AreEqual(weapon.DestructionLevel, expektedlevel);
            }
            [TestCase("WindRoller", 5, 9)]
            public void TestWeaponIsNuclear(string name, double price, int dlevel)
            {
                Weapon weapon = new Weapon(name, price, dlevel);
                weapon.IncreaseDestructionLevel();
                var isNuck = true;
                Assert.AreEqual(weapon.IsNuclear, isNuck);
            }
            [TestCase("WindRoller", 5, 4)]
            public void TestWeaponIsNOTNuclear(string name, double price, int dlevel)
            {
                Weapon weapon = new Weapon(name, price, dlevel);
                weapon.IncreaseDestructionLevel();
                var isNuck = false;
                Assert.AreEqual(weapon.IsNuclear, isNuck);
            }
            [TestCase("TITAN", 50)]
            public void TestPlanetConstruktor(string name, double budget)
            {
                var planet = new Planet(name, budget);
                Assert.AreEqual(planet.Name, name);
                Assert.AreEqual(planet.Budget, budget);
            }
            [TestCase("", 50)]
            [TestCase(null, 50)]
            public void TestPlanetNameSet(string name, double budget)
            {    
                Assert.Throws<ArgumentException>(() =>
                {
                    var planet = new Planet(name, budget);
                },
                "Invalid planet Name");
            }
            [TestCase("TITAN", -1)]
            [TestCase("TITAN", -200)]
            public void TestPlanetBudgetSet(string name, double budget)
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    var planet = new Planet(name, budget);
                },
                "Budget cannot drop below Zero!");
            }
            [TestCase("TITAN", 50)]
            [TestCase("TITAN", 20)]
            public void TestPlanetMilitaryPowerRatioPlusAddWeapon(string name, double budget)
            {
                var wepon1 = new Weapon("SpaceGun", 3, 5);
                var wepon2 = new Weapon("Yamato", 2, 4);
                var wepon3 = new Weapon("AtomB", 5, 7);
                var planet = new Planet(name, budget);
                planet.AddWeapon(wepon1);
                planet.AddWeapon(wepon2);
                planet.AddWeapon(wepon3);
                var expektedDlevel = 16;
                Assert.AreEqual(planet.MilitaryPowerRatio, expektedDlevel);
                
            }
            [TestCase("TITAN", 50)]
            [TestCase("TITAN", 20)]
            public void TestPlanetProfitMethod(string name, double budget)
            {             
                var planet = new Planet(name, budget);
                planet.Profit(10);
                var expektedDlevel = budget + 10;
                Assert.AreEqual(planet.Budget, expektedDlevel);

            }
            [TestCase("TITAN", 50)]
            public void TestPlanetSpendFundsShudThrowExceptiont(string name, double budget)
            {
                var planet = new Planet(name, budget);
                Assert.Throws<InvalidOperationException>(() =>
                {
                    planet.SpendFunds(60);
                },
                "Not enough funds to finalize the deal.");

            }
            [TestCase("TITAN", 50)]
            public void TestPlanetSpendFundsShud(string name, double budget)
            {
                var planet = new Planet(name, budget);
                planet.SpendFunds(10);
                var expektedFunds = 40;
                Assert.AreEqual(planet.Budget, expektedFunds);
            }
            [TestCase("TITAN", 50)]
            public void TestPlanetAddWeaponShudeThrowException(string name, double budget)
            {
                var wepon1 = new Weapon("SpaceGun", 3, 5);
                var planet = new Planet(name, budget);
                planet.AddWeapon(wepon1);
                Assert.Throws<InvalidOperationException>(() =>
                {
                    planet.AddWeapon(wepon1);
                },
                $"There is already a {wepon1.Name} weapon.");
            }
            [TestCase("TITAN", 50)]
            public void TestPlanetRemoveWeapon(string name, double budget)
            {
                var wepon1 = new Weapon("SpaceGun", 3, 5);
                var planet = new Planet(name, budget);
                planet.AddWeapon(wepon1);
                planet.RemoveWeapon("SpaceGun");
                var expektedCount = 0;
                Assert.AreEqual(planet.Weapons.Count, expektedCount);
            }
            [TestCase("TITAN", 50)]
            public void TestPlanetUpgradeWeaponShudThrowExceptio(string name, double budget)
            {
                var wepon1 = new Weapon("SpaceGun", 3, 5);
                var planet = new Planet(name, budget);
                planet.AddWeapon(wepon1);
                Assert.Throws<InvalidOperationException>(() =>
                {
                    planet.UpgradeWeapon("Yamato");
                },
                $"{wepon1.Name} does not exist in the weapon repository of {"Yamato"}");
            }
            [TestCase("TITAN", 50)]
            public void TestPlanetUpgradeWeapon(string name, double budget)
            {
                var wepon1 = new Weapon("SpaceGun", 3, 5);
                var planet = new Planet(name, budget);
                planet.AddWeapon(wepon1);
                planet.UpgradeWeapon(wepon1.Name);
                var expektedUpgreit = 6;
                Assert.AreEqual(wepon1.DestructionLevel, expektedUpgreit);
            }
            [TestCase("TITAN", 50)]
            public void TestPlanetDestructOpponentShudThrowException(string name, double budget)
            {
                var wepon1 = new Weapon("Space", 3, 5);
                var wepon2 = new Weapon("SpaceGun", 3, 10);
                var wepon3 = new Weapon("SpaceGn", 3, 7);
                var planet = new Planet(name, budget);
                var planet2 = new Planet("Aster", 60);
                planet.AddWeapon(wepon1);
                planet.AddWeapon(wepon2);
                planet2.AddWeapon(wepon1);
                planet2.AddWeapon(wepon2);
                planet2.AddWeapon(wepon3);
                Assert.Throws<InvalidOperationException>(() =>
                {
                    planet.DestructOpponent(planet2);
                },
               $"{planet2.Name} is too strong to declare war to!");
            }
            [TestCase("TITAN", 50)]
            public void TestPlanetDestructOpponent(string name, double budget)
            {
                var wepon1 = new Weapon("Space", 3, 5);
                var wepon2 = new Weapon("SpaceGun", 3, 10);
                var wepon3 = new Weapon("SpaceGn", 3, 7);
                var planet = new Planet(name, budget);
                var planet2 = new Planet("Aster", 60);
                planet.AddWeapon(wepon1);
                planet.AddWeapon(wepon2);
                planet.AddWeapon(wepon3);
                planet2.AddWeapon(wepon1);
                planet2.AddWeapon(wepon2);
                var meseg = $"{planet2.Name} is destructed!";
                Assert.AreEqual(planet.DestructOpponent(planet2), meseg);
            }
        }
    }
}
