using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPractice
{
    public class Deer
    {
        public double TotalDeerCount;
        public double BuckTotal;
        public double DoeTotal;

        public void AddingNewGeneration()
        {
            var newFawns = NewFawnsBornInAYear();
            AddToBuckCount(newFawns/2);
            AddToDoeTotal(newFawns/2);
            IncrementDeerTotal();
        }

        public void AddToBuckCount(double newBuckCount)
        {
            BuckTotal += newBuckCount;
        }

        public void AddToDoeTotal(double newDoeCount)
        {
            DoeTotal += newDoeCount;
        }

        public void IncrementDeerTotal()
        {
            TotalDeerCount = BuckTotal + DoeTotal;
        }

        public double NewFawnsBornInAYear()
        {
            var fawns = DoeTotal * 1.5;
            return Math.Round(fawns);
        }


    }
}
