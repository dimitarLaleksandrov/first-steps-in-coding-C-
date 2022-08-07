namespace Aquariums.Tests
{
    using System;
    using NUnit.Framework;
    public class AquariumsTests
    {
        [Test]
        [TestCase("Nemo", 1)]
        [TestCase("Nemo2", 10)]
        [TestCase("Nemo3", 999)]
        public void TestTheConstruktor(string name, int capacity)
        {
            Aquarium aquarium = new Aquarium(name, capacity);
            Assert.AreEqual(capacity, aquarium.Capacity);
            Assert.AreEqual(name, aquarium.Name);
        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void TestWhitInvalidName(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Aquarium aquarium = new Aquarium(name, 1);
            },
            "Invalid aquarium name!");
        }
        [Test]
        [TestCase("nemo1")]
        [TestCase("Nemo2")]
        public void TestISTheNameValueSet(string name)
        {
            Aquarium aquarium1 = new Aquarium(name, 1);
            Assert.AreEqual(aquarium1.Name, name);
        }
        [Test]
        [TestCase(-1)]
        [TestCase(-999)]
        [TestCase(int.MinValue)]
        public void TestCapacityArgumentException(int capacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Aquarium aquarium = new Aquarium("nemo", capacity);
            },
            "Invalid aquarium capacity!");
        }
        [Test]
        [TestCase("nemo1", 1)]
        [TestCase("Nemo2", 3)]
        [TestCase("Nemo3", 4)]
        public void TestCountAreSetAndAddFish(string name, int capacity)
        {
            Aquarium aquarium1 = new Aquarium(name, capacity);
            Fish fish = new Fish(name);
            aquarium1.Add(fish);
            int expektedCount = 1;
            Assert.AreEqual(expektedCount, aquarium1.Count);
        }
        [Test]
        [TestCase("nemo1", 1)]
        [TestCase("Nemo2", 1)]
        [TestCase("Nemo3", 1)]
        public void TestCantAddFish(string name, int capacity)
        {
            Aquarium aquarium1 = new Aquarium(name, capacity);
            Fish fish = new Fish(name);
            Fish fish2 = new Fish(name);
            aquarium1.Add(fish);
            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium1.Add(fish2);
            },
            "Aquarium is full!");
        }
        [Test]
        [TestCase("nemo1", 4)]
        [TestCase("Nemo2", 4)]
        [TestCase("Nemo3", 4)]
        public void TestRemoveFishCorektli(string name, int capacity)
        {
            Aquarium aquarium1 = new Aquarium(name, capacity);
            Fish fish = new Fish(name);
            Fish fish2 = new Fish(name);
            aquarium1.Add(fish);
            aquarium1.Add(fish2);
            aquarium1.Add(fish);
            aquarium1.RemoveFish(name);
            int expektedCount = 2;
            Assert.AreEqual(expektedCount, aquarium1.Count);
        }
        [Test]
        [TestCase("nemo1", 4)]
        [TestCase("Nemo2", 4)]
        [TestCase("Nemo3", 4)]
        public void TestCantRemoveFish(string name, int capacity)
        {
            Aquarium aquarium1 = new Aquarium(name, capacity);
            Fish fish = new Fish("");
            Fish fish2 = new Fish("");
            aquarium1.Add(fish);
            aquarium1.Add(fish2);
            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium1.RemoveFish(name);
            },
            $"Fish with the name {name} doesn't exist!");
        }
        [Test]
        [TestCase("nemo1", 4)]
        [TestCase("Nemo2", 4)]
        public void TestSellFishAvailable(string name, int capacity)
        {
            Aquarium aquarium1 = new Aquarium(name, capacity);
            Fish fish = new Fish(name);
            Fish fish2 = new Fish(name);
            aquarium1.Add(fish);
            aquarium1.Add(fish2);
            Fish fish3 = aquarium1.SellFish(name);
            Assert.IsFalse(fish3.Available);
        }
        [Test]
        [TestCase("nemo1", 4)]
        [TestCase("Nemo2", 4)]
        public void TestSellFishFaild(string name, int capacity)
        {
            Aquarium aquarium1 = new Aquarium(name, capacity);
            Fish fish = new Fish(name);
            Fish fish2 = new Fish(name);
            aquarium1.Add(fish);
            aquarium1.Add(fish2);
            Fish fish3 = aquarium1.SellFish(name);
            Assert.Throws<InvalidOperationException>(() =>
            {
                aquarium1.SellFish("ne");
            },
            $"Fish with the name {name} doesn't exist!");
        }
        [Test]
        [TestCase("nemo1", 4)]
        [TestCase("Nemo2", 4)]
        public void TestReportWhitFishes(string name, int capacity)
        {
            Aquarium aquarium1 = new Aquarium(name, capacity);
            Fish fish = new Fish(name);
            Fish fish2 = new Fish(name);
            aquarium1.Add(fish);
            aquarium1.Add(fish2);
            string expReport = $"Fish available at {name}: {fish.Name}, {fish2.Name}";
            Assert.AreEqual(expReport, aquarium1.Report());
        }
        [Test]
        [TestCase("nemo1", 4)]
        [TestCase("Nemo2", 4)]
        public void TestReportWhitEmptyAquarium(string name, int capacity)
        {
            Aquarium aquarium1 = new Aquarium(name, capacity);
            string expReport = $"Fish available at {name}: ";
            Assert.AreEqual(expReport, aquarium1.Report());
        }
    }
}
