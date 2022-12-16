using System;
using NUnit.Framework;
using Roman_Numbers_Converter;

namespace TestProject
{
    public class Roman_Numbers_Tests
    {
      

        [Test]
        [TestCase(2754, "MMDCCLIV")]
        [TestCase(754, "DCCLIV")]
        [TestCase(54, "LIV")]
        [TestCase(4, "IV")]
        [TestCase(4000, "Erorr! Number must be between 1 and 3999.")]
        [TestCase(0, "Erorr! Number must be between 1 and 3999.")]
        public void Convert_Test(int number, string result)
        {
            string actualResult = RomanNumbers.Convert(number);
            string expectedResult = result;

            Assert.AreEqual(expectedResult, actualResult, "The results are not the same.");

        }
    }
}