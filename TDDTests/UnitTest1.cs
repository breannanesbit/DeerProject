using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDPractice;

namespace TDDTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IncrementDeerCount()
        {
            Deer.IncrementDeerTotal();
        }
    }
}
