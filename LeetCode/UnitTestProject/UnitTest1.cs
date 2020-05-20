using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private LeetCode.LeetCode code = new LeetCode.LeetCode();

        [TestMethod]
        public void TwoSumInputNull()
        {
            int time = 0;
            string actual = code.TwoSum(null, 7, ref time);

            Assert.AreEqual("", actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void TwoSumNotFind()
        {
            int time = 0;
            string actual = code.TwoSum(new int[] { 1, 3, 5, 7 }, 7, ref time);

            Assert.AreEqual("not find", actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void TwoSum()
        {
            int time = 0;
            string actual = code.TwoSum(new int[] { 1, 3, 9, 4 }, 7, ref time);

            Assert.AreEqual("1,3", actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void ReverseIlnteger()
        {
            int time = 0;
            int actual = code.ReverseInteger(-123, ref time);

            Assert.AreEqual(-321, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void ReverseIlntegerOverPower()
        {
            int time = 0;
            int actual = code.ReverseInteger(65539, ref time);

            Assert.AreEqual(0, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void PalindromeNumberSingleInput()
        {
            int time = 0;
            bool actual = code.PalindromeNumber(0, ref time);

            Assert.AreEqual(false, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void PalindromeNumber()
        {
            int time = 0;
            bool actual = code.PalindromeNumber(10, ref time);

            Assert.AreEqual(false, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void RomantoIntegerNotMap()
        {
            int time = 0;
            int actual = code.RomantoInteger("ABMCM", ref time);

            Assert.AreEqual(0, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void RomantoInteger()
        {
            int time = 0;
            int actual = code.RomantoInteger("MCMXCIV", ref time);

            Assert.AreEqual(1994, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void LongestCommonPrefixInputNull()
        {
            int time = 0;
            string actual = code.LongestCommonPrefix(null, ref time);

            Assert.AreEqual("", actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void LongestCommonPrefixNotCommon()
        {
            int time = 0;
            string actual = code.LongestCommonPrefix(new[] { "abc", "edf", "uyio" }, ref time);

            Assert.AreEqual("", actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void LongestCommonPrefix()
        {
            int time = 0;
            string actual = code.LongestCommonPrefix(new[] { "flower", "flow", "flight" }, ref time);

            Assert.AreEqual("fl", actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void ValidParenthesesInputNull()
        {
            int time = 0;
            bool actual = code.ValidParentheses(null, ref time);

            Assert.AreEqual(false, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void ValidParenthesesInputError()
        {
            int time = 0;
            bool actual = code.ValidParentheses("{", ref time);

            Assert.AreEqual(false, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void ValidParentheses()
        {
            int time = 0;
            bool actual = code.ValidParentheses("()[]{}", ref time);

            Assert.AreEqual(true, actual);
            Console.WriteLine(time);
        }
    }
}
