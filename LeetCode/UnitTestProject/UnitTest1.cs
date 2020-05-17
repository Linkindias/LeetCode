﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private LeetCode.LeetCode code = new LeetCode.LeetCode();
        [TestMethod]
        public void TwoSum()
        {
            int time = 0;
            string actual = code.TwoSum(new int[] {1,3,9,4},7,ref time);

            Assert.AreEqual("1,3", actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void ReverseInteger()
        {
            int time = 0;
            int actual = code.ReverseInteger(-123, ref time);

            Assert.AreEqual(-321, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void PalindromeNumber()
        {
            int time = 0;
            bool actual = code.PalindromeNumber(-123, ref time);

            Assert.AreEqual(false, actual);
            Console.WriteLine(time);
        }
        
    }
}