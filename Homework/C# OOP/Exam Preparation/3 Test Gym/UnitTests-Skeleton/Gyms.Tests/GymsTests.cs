using NUnit.Framework;
using System;

namespace Gyms.Tests
{
    public class GymsTests
    {
        [Test]
        [TestCase("WestGym", 10)]
        public void TestCtor(string name, int capacity)
        {
            var gym = new Gym(name, capacity);
            Assert.AreEqual(gym.Name, name);
            Assert.AreEqual(gym.Capacity, capacity);
        }
        [Test]
        [TestCase("", 1)]
        [TestCase(null, 10)]
        public void TestNameThrowException(string name, int capacity)
        {
            Assert.Throws<ArgumentNullException>(() => new Gym(name, capacity));
        }

        [Test]
        [TestCase("Mitko", -1)]
        public void TestCapacityThrowExc(string name, int capacity)
        {
            Assert.Throws<ArgumentException>(() => new Gym(name, capacity));
        }

        [Test]
        [TestCase("West", 1)]
        public void TestCount(string name, int capacity)
        {
            var gym = new Gym(name, capacity);
            var expectedCount = 1;
            gym.AddAthlete(new Athlete(name));
            Assert.AreEqual(expectedCount, gym.Count);
        }
        [Test]
        [TestCase("West", 0)]
        public void TestAddThrowException(string name, int capacity)
        {
            var gym = new Gym(name, capacity);
            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(new Athlete(name)));
        }
        [Test]
        [TestCase("Mitko", 1)]
        public void TestRemoveThrowException(string name, int capacity)
        {
            var gym = new Gym(name, capacity);
            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete(null));
        }
        [Test]
        public void TestRemoveWorkCorrect()
        {
            var gym = new Gym("Rado", 3);
            gym.AddAthlete(new Athlete("Spiro"));
            gym.AddAthlete(new Athlete("Miro"));
            gym.AddAthlete(new Athlete("Kiro"));
            gym.RemoveAthlete("Spiro");
            gym.RemoveAthlete("Miro");

            Assert.AreEqual(gym.Count, 1);
        }
        [Test]
        public void TestInjuredThrowException()
        {
            var gym = new Gym("west", 1);
            gym.AddAthlete(new Athlete("Miro"));
            Assert.Throws<InvalidOperationException>(() => gym.InjureAthlete(null));
        }
        [Test]
        public void TestInjuredCorrect()
        {
            var gym = new Gym("west", 1);
            gym.AddAthlete(new Athlete("Miro"));
            var athlete = gym.InjureAthlete("Miro");
            Assert.AreEqual(gym.InjureAthlete("Miro"), athlete);
        }

        [Test]
        public void MethodReport()
        {
            var gym = new Gym("west", 1);
            gym.AddAthlete(new Athlete("Spiro"));
            var expectedMsg = $"Active athletes at west: Spiro";
            Assert.AreEqual(expectedMsg, gym.Report());
        }
    }
}
