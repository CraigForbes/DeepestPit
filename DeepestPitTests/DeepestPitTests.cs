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

        [TestMethod]
        public void OnlyDescending()
        {
            int[] array = new int[] { 5, 3, 1, -1, -3 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void OnlyAscending()
        {
            int[] array = new int[] { -3, -1, 1, 3, 5 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void SimpleWaveEndDownSlope()
        {
            int[] array = new int[] { 0, 1, 2, 1, 0, 1, 2, 1, 0, 1, 2, 1, 0 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ComplexUpsDowns()
        {
            int[] array = new int[] { 0, 1, 2, 3, 3, -2, -1, 0, 1, 0, -3, 2, 3 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SimpleWaveEndUpSlope()
        {
            int[] array = new int[] { 2, 1, 0, 1, 2, 1, 0, 1, 2, 1, 0, 1, 2 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FlatEndNoHill()
        {
            int[] array = new int[] { 3, 2, 1, 1 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TripleDescending()
        {
            int[] array = new int[] { 3, 2, 1, 3, 2, 1, 3, 2, 1 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TripleAscending()
        {
            int[] array = new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void BigNumbersTest()
        {
            int[] array = new int[] { 0, 100, 300, -200, 0, 100, 0, -300, 200, 300 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(400, result);
        }

        [TestMethod]
        public void BigNumbersTestWithUpsDowns()
        {
            int[] array = new int[] { 0, 100, 100, 110, 105, 300 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void RepeatingNumbers()
        {
            int[] array = new int[] { 5, 2, 2, 2, 1, 5 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void RepeatingNumbersHigher()
        {
            int[] array = new int[] { 5, 2, 2, 3, 1, 5 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ThreeOfTheSame()
        {
            int[] array = new int[] { 10, 10, 10 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void HasNoInput()
        {
            int[] array = new int[] { };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void BasicTestNegative()
        {
            int[] array = new int[] { -1, 5, 5, -1, -2, -3, -2, -4, -1, -2, -3, -2, -3, -2 };

            var solution = new DeepestPitSolution();
            var result = solution.Solution(array);

            Assert.AreEqual(2, result);
        }
    }
}
