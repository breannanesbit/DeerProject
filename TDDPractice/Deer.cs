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
        public double FawnTotal;
        public int[] PrimeNum = new [] {2,3,5,7,13};

        public void AddFawnCount(double count)
        {
            FawnTotal += count; 
        }

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

        public string DoeToFawnRatio(double doe, double fawn)
        {
            double simplifiedDoe = doe;
            double simplifiedFawn = fawn;
            string simplifiedString = "";
            foreach(var i in PrimeNum)
            {
                if(doe%i == 0  && fawn%i == 0)
                {
                    simplifiedString = DoeToFawnRatio(doe/i, fawn/i);
                }
            }

            if(simplifiedString == "")
            {
                return $"{simplifiedDoe}:{simplifiedFawn}";
            }
            else
                return simplifiedString;
            
            /*if(DoeTotal > FawnTotal)
            {
                if(DoeTotal%FawnTotal != 0)
                {
                    return $"{DoeTotal}:{FawnTotal}";
                }
                return $"{DoeTotal/FawnTotal}:{FawnTotal/FawnTotal}";
            }

            else if(DoeTotal < FawnTotal)
            {
                if(FawnTotal%DoeTotal != 0)
                {
                    return $"{DoeTotal}:{FawnTotal}";
                }
            }*/
            
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
