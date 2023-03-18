using TDDPractice;
using static TDDPractice.Deer;

namespace TDDTest
{
    public class Tests
    {
        public Deer deer = new();
        [SetUp]
        public void Setup()
        {
          
        }

        [Test]
        public void AddingToBuckTotal()
        {
            deer.AddToBuckCount(5);
            Assert.AreEqual(5, deer.BuckTotal);
        }

        [Test]
        public void AddingToDoeTotal()
        {
            deer.AddToDoeTotal(15);
            Assert.AreEqual(15, deer.DoeTotal);
        }
        [Test]
        public void IncrementDeerCount()
        {
            deer.IncrementDeerTotal();
            Assert.AreEqual(deer.DoeTotal + deer.BuckTotal, deer.TotalDeerCount);
        }

        [Test]
        public void NewFawns()
        {
            deer.AddToDoeTotal(15);
            var fawns = deer.NewFawnsBornInAYear();
            Assert.AreEqual(22, fawns);
        }
        [Test]
        public void AddNewBornsToTotal()
        {
            deer.AddToBuckCount(5);
            deer.AddToDoeTotal(15);
            deer.AddingNewGeneration();
            Assert.AreEqual(26, deer.DoeTotal);
            Assert.AreEqual(16, deer.BuckTotal);
            Assert.AreEqual(42, deer.TotalDeerCount);
        }
    }
}