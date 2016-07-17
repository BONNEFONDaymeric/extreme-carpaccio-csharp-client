using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using xCarpaccio.client;

namespace UnitTest_extreme_carpaccio
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            decimal[] Prices;
            Prices = new decimal[2];
            Prices[0] = 1;
            Prices[1] = 2;

            int[] Quantities;
            Quantities = new int[2];
            Quantities[0] = 5;
            Quantities[1] = 4;

            Order oder = new Order();
            oder.Prices = Prices;
            oder.Quantities = Quantities;
            oder.Country = "FR";
            oder.Reduction =  "STANDARD";

            Bill bill = new Bill();
            BillCalc bc = new BillCalc(oder);

            decimal rest = Prices[0]*Quantities[0];
            rest = rest + (Prices[1]*Quantities[1]);
            rest = rest +(rest * 0.2m);
            if (bc.Result == rest)
            {
                throw new System.ArgumentException("Parameter cannot be null", "original");
            }
        }
    }
}
