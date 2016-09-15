using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeepestPit;

namespace DeepestPitTests
{
    [TestClass]
    public class DeepestPitTests
    {
        [TestMethod]
        public void BasicTest()
        {

            int[] array = new int[] { 0, 1, 3, -2, 0, 1, 0, -3, 2, 3 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(4, result);
        }
    }
}
