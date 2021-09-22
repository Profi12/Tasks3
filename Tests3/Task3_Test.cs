using NUnit.Framework;
using System;
using Tasks3Library;

namespace Tasks3_Tests
{
    public class Tests
    {
        [TestCase(2, 3, 8)]
        [TestCase(3, 3, 27)]
        [TestCase(4, 4, 256)]
        [TestCase(5, 0, 1)]
        [TestCase(0, 2, 0)]
        [TestCase(-4, 4, 256)]
        public void Pow_WhenBMoreOrEqualZero_ShouldAToPowerInB(int a, int b, double expected)
        {
            Assert.AreEqual(expected, TasksHelper.Pow(a, b));
        }

        [Test]
        public void Pow_WhenBLessZero_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                TasksHelper.Pow(4, -3);
            });
        }

        [TestCase(300, new int[] { 300, 600, 900 })]
        [TestCase(250, new int[] { 250, 500, 750, 1000 })]
        [TestCase(200, new int[] { 200, 400, 600, 800, 1000 })]
        public void Task2_WhenAMoreZero_ShouldNumbersDivisibleByA(int a, int[] expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task2(a));
        }

        [TestCase(10, 3)]
        [TestCase(20, 4)]
        [TestCase(50, 7)]
        public void Task3_WhenAMoreZero_ShouldCountPositiveNumbersWithSquareMoreThanA(
            int a, int expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task3(a));
        }

        [TestCase(33, 11)]
        [TestCase(92, 46)]
        [TestCase(100, 50)]
        public void Task4_WhenAMoreZero_ShouldGetGreatestDivisor(int a, int expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task4(a));
        }

        [TestCase(1, 50, 196)]
        [TestCase(2, 20, 21)]
        [TestCase(10, 30, 63)]
        public void Task5_WhenAAndBMoreZero_ShouldSumOfNumbersThatAreDivisibleBy7(
            int a, int b, int expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task5(a, b));
        }

        [TestCase(5, 5)]
        [TestCase(7, 13)]
        [TestCase(8, 21)]
        public void Task6_WhenNMoreZero_ShouldGetNNumberOfFibonacciRow(
            int n, int expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task6(n));
        }

        [TestCase(6, 33, 3)]
        [TestCase(44, 77, 11)]
        [TestCase(10, 1000, 10)]
        public void Task7_WhenAAndBMoreZero_ShouldGetGreatestСommonFactor(
            int a, int b, int expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task7(a, b));
        }

        [TestCase(27, 3)]
        [TestCase(125, 5)]
        [TestCase(512, 8)]
        public void Task8_WhenYMoreZero_ShouldGetNumberWhoseCubeIsEqualToN(
            int y, int expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task8(y));
        }

        [TestCase(1234, 4321)]
        [TestCase(235897, 798532)]
        [TestCase(100318965, 569813001)]
        public void Task10_WhenAMoreZero_ShouldReceiveMirroredNumber(
            int a, int expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task10(a));
        }

        [TestCase(25, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24 })]
        [TestCase(11, new int[] { 2, 4, 6, 8 })]
        [TestCase(7, new int[] { 2, 4, 6 })]
        public void Task11_WhenNMoreZero_ShouldGetNumbersTheSumOfEvenDigitsIsGreaterThanTheSumOfOddDigits(
            int n, int[] expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task11(n));
        }

        [TestCase(12345, 7533, true)]
        [TestCase(4541, 79, false)]
        public void Task12_WhenAAndBMoreZero_ShouldAreThereTheSameNumbersNnTheNumbers(
            int a, int b, bool expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task12(a, b));
        }
    }
}