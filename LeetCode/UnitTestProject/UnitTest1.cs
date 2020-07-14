using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class LeetCodeTest
    {
        private LeetCode _leetCode = new LeetCode();

        [TestMethod]
        public void TwoSumInputNull()
        {
            TwoSumShouldBe("", new int[0], 0);
        }

        [TestMethod]
        public void TwoSum()
        {
            TwoSumShouldBe("1,3", new int[] {1,2,3,4,5}, 6);
        }
        private void TwoSumShouldBe(string expected, int[] ints, int target)
        {
            Assert.AreEqual(expected, _leetCode.TwoSum(ints,target));
        }
    }
}