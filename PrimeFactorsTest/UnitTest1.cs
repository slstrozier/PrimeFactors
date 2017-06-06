using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrimeFactorGenerator;

namespace PrimeFactorsTest
{
    [TestClass]
    public class PrimeFactorsUnitTest
    {
        [TestMethod]
        [DataRow(1, new int[] { })]
        [DataRow(2, new int[] { 2 })]
        [DataRow(3, new int[] { 3 })]
        [DataRow(4, new int[] { 2, 2 })]
        [DataRow(5, new int[] { 5 })]
        [DataRow(6, new int[] { 2, 3 })]
        [DataRow(7, new int[] { 7 })]
        [DataRow(8, new int[] { 2,2,2 })]
        [DataRow(9, new int[] { 3, 3 })]
        [DataRow(74, new int[] { 2, 37 })]
        public void Generate_WithNumber_ReturnsExpectedList(int number, int[] expected)
        {
            List<int> result = PrimeFactorGenerator.PrimeFactorGenerator.GenerateFactors(number);

            CollectionAssert.AreEqual(result, expected);
        }

    }
}
