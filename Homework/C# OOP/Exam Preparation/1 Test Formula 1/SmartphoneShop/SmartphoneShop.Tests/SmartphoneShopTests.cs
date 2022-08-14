using NUnit.Framework;
using System;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(-45)]
        [TestCase(-99)]
        public void TestCapacityShop(int num)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var shop = new Shop(num);
            },
            "Invalid capacity.");
        }
        [Test]
        [TestCase(0)]
        [TestCase(99)]
        public void TestCapacitySetProp(int num)
        {
            var shop = new Shop(num);
            var shopCount = num;
            Assert.AreEqual(shopCount, shop.Capacity);
        }
        [Test]
        [TestCase("Motorola", 10)]
        [TestCase("Nokia", 15)]
        public void TestCountVaule(string name, int num)
        {
            var shop = new Shop(num);
            var phove1 = new Smartphone(name, num);
            shop.Add(phove1);
            var expektedCount = 1;
            Assert.AreEqual(expektedCount, shop.Count);
        }
        [Test]
        [TestCase("Motorola", 10)]
        [TestCase("Nokia", 15)]
        public void TestAddedPhoneToShopThrowInvalidOperationException(string name, int num)
        {
            var shop = new Shop(num);
            var phove1 = new Smartphone(name, num);
            shop.Add(phove1);
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Add(phove1);
            },
           $"The phone model {phove1.ModelName} already exist.");
        }
        [Test]
        [TestCase("Motorola", 1)]
        [TestCase("Nokia", 1)]
        public void TestShopCapacityThrowInvalidOperationException(string name, int num)
        {
            var shop = new Shop(num);
            var phove1 = new Smartphone(name, num);
            var phove2 = new Smartphone("Nokia", 2);
            shop.Add(phove1);
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Add(phove2);
            },
           "The shop is full.");
        }
        [Test]
        [TestCase("Motorola", 1)]
        [TestCase("Nokia", 1)]
        public void TestRemovePhoneShudThrowInvalidOperationException(string name, int num)
        {
            var shop = new Shop(10);
            var phove1 = new Smartphone(name, num);
            var phove2 = new Smartphone("Lenovo", 2);
            shop.Add(phove1);
            shop.Add(phove2);
            var n = "NVidia";
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.Remove(n);
            },
           $"The phone model {n} doesn't exist.");
        }
        [Test]
        [TestCase("Motorola", 1)]
        [TestCase("Nokia", 1)]
        public void TestRemovePhoneSucsess(string name, int num)
        {
            var shop = new Shop(10);
            var phove1 = new Smartphone(name, num);
            var phove2 = new Smartphone("Lenovo", 2);
            shop.Add(phove1);
            shop.Add(phove2);
            var phoneCount = 1;
            shop.Remove(phove1.ModelName);
            Assert.AreEqual(phoneCount, shop.Count);
           
        }
        [Test]
        [TestCase("Motorola", 1)]
        [TestCase("Nokia", 1)]
        public void TestTestPhoneShudThrowInvalidOperationException(string name, int num)
        {
            var shop = new Shop(10);
            var phove1 = new Smartphone(name, num);
            var phove2 = new Smartphone("Lenovo", 2);
            shop.Add(phove1);
            shop.Add(phove2);
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.TestPhone("Hi", 1);
            },
           $"The phone model Hi doesn't exist.");

        }
        [Test]
        [TestCase("Motorola", 1)]
        [TestCase("Nokia", 1)]
        public void TestTestPhoneShudThrowInvalidOperationExceptionWhitBatteri(string name, int num)
        {
            var shop = new Shop(10);
            var phove1 = new Smartphone(name, num);
            var phove2 = new Smartphone("Lenovo", 2);
            shop.Add(phove1);
            shop.Add(phove2);
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.TestPhone(name, 2);
            },
           $"The phone model {name} is low on batery.");

        }
        [Test]
        [TestCase("Motorola", 3)]
        [TestCase("Nokia", 3)]
        public void TestTestPhoneBatteryUsage(string name, int num)
        {
            var shop = new Shop(10);
            var phove1 = new Smartphone(name, num);
            var phove2 = new Smartphone("Lenovo", 3);
            shop.Add(phove1);
            shop.Add(phove2);
            shop.TestPhone(name, 1);
            var expektetbateri = 2;
            Assert.AreEqual(expektetbateri, phove1.CurrentBateryCharge);
        }
        [Test]
        [TestCase("Motorola", 3)]
        [TestCase("Nokia", 3)]
        public void TestChargePhoneShudThrowExceptio(string name, int num)
        {
            var shop = new Shop(10);
            var phove1 = new Smartphone(name, num);
            var phove2 = new Smartphone("Lenovo", 3);
            shop.Add(phove1);
            shop.Add(phove2);
            Assert.Throws<InvalidOperationException>(() =>
            {
                shop.ChargePhone("T");
            },
            $"The phone model T doesn't exist.");
        }
        [Test]
        [TestCase("Motorola", 3)]
        [TestCase("Nokia", 3)]
        public void TestTestPhoneBatteryIsCharg(string name, int num)
        {
            var shop = new Shop(10);
            var phove1 = new Smartphone(name, num);
            var phove2 = new Smartphone("Lenovo", 3);
            shop.Add(phove1);
            shop.Add(phove2);
            shop.TestPhone(name, 2);
            shop.ChargePhone(name);
            var expektetbateri = 3;
            Assert.AreEqual(expektetbateri, phove1.CurrentBateryCharge);
        }
    }
}