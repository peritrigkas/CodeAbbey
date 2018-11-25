using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeAbbey;


namespace CodeAbbeyTests
{
    [TestClass]
    public class ArithmeticProgressionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,,] arraySequence = new int[2, 2, 3] { { { 1, 3, 3}, { 2, 1, 2} },
                                                       { { 1, 2, 3}, { 4, 3, 2} } };

            int[] expected = new int [] { 12, 5, 9, 11};
            ArithmeticProgression CalculateProgression = new ArithmeticProgression();

            int[] result= CalculateProgression.progression(arraySequence);

            CollectionAssert.AreEqual(expected, result);



        }
    }
}
