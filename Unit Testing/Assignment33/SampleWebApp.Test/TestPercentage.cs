using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SampleWebApp.Test
{
    [TestClass]
    public class TestPercentage
    {
        float expected, actual;
        Student student = new Student();
        //test case to check upper boundary value
        [TestMethod]
        public void TestUpperBoundary()
        {
            string boundaryPercentageLower = "0";
            expected = 0;
            actual = student.GetPercentage(boundaryPercentageLower);
            Assert.AreEqual(actual, expected);
        }
        //test case to check lower boundary value
        [TestMethod]
        public void TestLowerBoundary()
        {
            string boundaryPercentageUpper = "100";
            expected = 100;
            actual = student.GetPercentage(boundaryPercentageUpper);
            Assert.AreEqual(actual, expected);
        }
        //test case to check for a positive case
        [TestMethod]
        public void TestPositiveCase()
        {
            string positivePercentage = "80";
            expected = 80;
            actual = student.GetPercentage(positivePercentage);
            Assert.AreEqual(actual, expected);
        }
        //test case to check for a negative case
        [TestMethod]
        public void TestNegativeCase()
        {
            string negativePercentage = "-200";
            expected = 0;
            actual = student.GetPercentage(negativePercentage);
            Assert.AreEqual(actual, expected);
        }
        //test case for a thrown exception
        [TestMethod]
        [ExpectedException(typeof(FormatException), "Input string was not in a correct format.")]
        public void TestFormatException()
        {
            string stringPercentage = "ABC";
            actual = student.GetPercentage(stringPercentage);
        }
    }
}
