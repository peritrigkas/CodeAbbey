﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeAbbey;

namespace CodeAbbeyTests
{
    [TestClass]
    public class FarheneitToCelciousTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] Fahreneit = new int[5];
            int[] expected = new int[] { -16, 1, 296, 38, 100 };
            //double[] actual = new double[] { -16, 1, 296, 38, 100 };
            FahrenheitToCelcious celciousTest = new FahrenheitToCelcious();

            int[] actual= celciousTest.Conversion(Fahreneit);

            CollectionAssert.AreEqual(expected, actual);

                      

        }
    }
}
