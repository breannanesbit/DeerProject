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

        [Test]
        public void FawnCount()
        {
            deer.AddFawnCount(0);
            Assert.AreEqual(0, deer.FawnTotal);
            deer.AddFawnCount(5);
            Assert.AreEqual(5, deer.FawnTotal);
            deer.AddFawnCount(10);
            Assert.AreEqual(15, deer.FawnTotal);
        }

        [Test]
        public void DoeToDawnRatio()
        {
            deer.AddFawnCount(1);
            deer.AddToDoeTotal(1);
            var ratio = deer.DoeToFawnRatio(deer.DoeTotal, deer.FawnTotal);
            Assert.AreEqual("1:1",ratio);
        }

        [Test]
        public void DoeToDawnRatio2()
        {
            deer.AddFawnCount(2);
            deer.AddToDoeTotal(2);
            var ratio = deer.DoeToFawnRatio(deer.DoeTotal, deer.FawnTotal);
            Assert.AreEqual("1:1",ratio);
        }

        [Test]
        public void DoeToDawnRatio3()
        {
            deer.AddFawnCount(3);
            deer.AddToDoeTotal(3);
            var ratio = deer.DoeToFawnRatio(deer.DoeTotal, deer.FawnTotal);
            Assert.AreEqual("1:1",ratio);
        }

        [Test]
        public void DoeToDawnRatio2_1()
        {
            deer.AddFawnCount(1);
            deer.AddToDoeTotal(2);
            var ratio = deer.DoeToFawnRatio(deer.DoeTotal, deer.FawnTotal);
            Assert.AreEqual("2:1",ratio);
        }

        [Test]
        public void DoeToDawnRatio3_2()
        {
            deer.AddFawnCount(2);
            deer.AddToDoeTotal(3);
            var ratio = deer.DoeToFawnRatio(deer.DoeTotal, deer.FawnTotal);
            Assert.AreEqual("3:2",ratio);
        }

        [Test]
        public void DoeToDawnRatio5_2()
        {
            deer.AddFawnCount(2);
            deer.AddToDoeTotal(5);
            var ratio = deer.DoeToFawnRatio(deer.DoeTotal, deer.FawnTotal);
            Assert.AreEqual("5:2",ratio);
        }

        [Test]
        public void DoeToDawnRatio21_7()
        {
            deer.AddFawnCount(7);
            deer.AddToDoeTotal(21);
            var ratio = deer.DoeToFawnRatio(deer.DoeTotal, deer.FawnTotal);
            Assert.AreEqual("3:1",ratio);
        }

        [Test]
        public void DoeToDawnRatio8_6()
        {
            deer.AddFawnCount(6);
            deer.AddToDoeTotal(8);
            var ratio = deer.DoeToFawnRatio(deer.DoeTotal, deer.FawnTotal);
            Assert.AreEqual("4:3",ratio);
        }

        [Test]
        public void DoeToDawnRatio81_9()
        {
            deer.AddFawnCount(9);
            deer.AddToDoeTotal(81);
            var ratio = deer.DoeToFawnRatio(deer.DoeTotal, deer.FawnTotal);
            Assert.AreEqual("9:1",ratio);
        }
    }
}