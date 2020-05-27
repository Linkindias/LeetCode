using System;
using System.Collections.Generic;
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
        public void ValidParenthesesInputLengthSingle()
        {
            int time = 0;
            bool actual = code.ValidParentheses("{}[", ref time);

            Assert.AreEqual(false, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void ValidParenthesesInputError()
        {
            int time = 0;
            bool actual = code.ValidParentheses("{}[)", ref time);

            Assert.AreEqual(false, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void ValidParentheses()
        {
            int time = 0;
            bool actual = code.ValidParentheses("([{]})", ref time);

            Assert.AreEqual(true, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void MergeTwoSortedListsInputNull()
        {
            int time = 0;
            LinkedList<string> actuals = code.MergeTwoSortedLists(new LinkedList<string>(), new LinkedList<string>(), ref time);

            foreach (string word in actuals)
                Assert.AreEqual(string.Empty, word);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void MergeTwoSortedLists()
        {
            int time = 0;
            var e1 = new LinkedList<string>(); e1.AddFirst("5"); e1.AddFirst("3"); e1.AddFirst("1");
            var e2 = new LinkedList<string>(); e2.AddFirst("6"); e2.AddFirst("4"); e2.AddFirst("2");
            var actuals = code.MergeTwoSortedLists(e1, e2, ref time).GetEnumerator();

            var expects = new LinkedList<string>();
            expects.AddFirst("6"); expects.AddFirst("5"); expects.AddFirst("4"); expects.AddFirst("3"); expects.AddFirst("2"); expects.AddFirst("1");

            var expect = expects.GetEnumerator();

            while (expect.MoveNext() && actuals.MoveNext())
            {
                Assert.AreEqual(expect.Current, actuals.Current);
            }
            Console.WriteLine(time);
        }

        [TestMethod]
        public void RemoveDuplicatesfromSortedArrayInputNull()
        {
            int time = 0;
            int actual = code.RemoveDuplicatesfromSortedArray(null, ref time);

            Assert.AreEqual(0, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void RemoveDuplicatesfromSortedArray()
        {
            int time = 0;
            int actual = code.RemoveDuplicatesfromSortedArray(new int[] { 1, 1, 3, 4, 5, 5, 7 }, ref time);

            Assert.AreEqual(5, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void RemoveElementInputArrayNull()
        {
            int time = 0;
            int actual = code.RemoveElement(null, 0, ref time);

            Assert.AreEqual(0, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void RemoveElementInputRemoveNull()
        {
            int time = 0;
            int actual = code.RemoveElement(new int[] { 1, 2, 3, 4, 5, 7 }, 0, ref time);

            Assert.AreEqual(6, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void RemoveElement()
        {
            int time = 0;
            int actual = code.RemoveElement(new int[] { 1, 1, 3, 4, 5, 5, 7 }, 5, ref time);

            Assert.AreEqual(5, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void ImplementstrStrInputNull()
        {
            int time = 0;
            int actual = code.ImplementstrStr(null, "", ref time);

            Assert.AreEqual(0, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void ImplementstrStrFindNull()
        {
            int time = 0;
            int actual = code.ImplementstrStr("abc", null, ref time);

            Assert.AreEqual(0, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void ImplementstrStrSameNull()
        {
            int time = 0;
            int actual = code.ImplementstrStr(null, null, ref time);

            Assert.AreEqual(0, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void ImplementstrStr()
        {
            int time = 0;
            int actual = code.ImplementstrStr("abawefn", "aw", ref time);

            Assert.AreEqual(2, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void SearchInsertPositionInputNull()
        {
            int time = 0;
            int actual = code.SearchInsertPosition(null, 1, ref time);

            Assert.AreEqual(0, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void SearchInsertPositionTargetNull()
        {
            int time = 0;
            int actual = code.SearchInsertPosition(new int[] { 1, 3, 4, 7 }, 0, ref time);

            Assert.AreEqual(0, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void SearchInsertPosition()
        {
            int time = 0;
            int actual = code.SearchInsertPosition(new int[] { 1, 3, 5, 9 }, 7, ref time);

            Assert.AreEqual(3, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void CountandSayInputZero()
        {
            int time = 0;
            string actual = code.CountandSay(0, ref time);

            Assert.AreEqual(string.Empty, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void CountandSayInputOne()
        {
            int time = 0;
            string actual = code.CountandSay(1, ref time);

            Assert.AreEqual("1", actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void CountandSayScopeOut()
        {
            int time = 0;
            string actual = code.CountandSay(33, ref time);

            Assert.AreEqual(string.Empty, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void CountandSay()
        {
            int time = 0;
            string actual = code.CountandSay(10, ref time);

            Assert.AreEqual("121122112221112221112211", actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void MaximumSubarrayInputNull()
        {
            int time = 0;
            int actual = code.MaximumSubarray(null, ref time);

            Assert.AreEqual(0, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void MaximumSubarray()
        {
            int time = 0;
            int actual = code.MaximumSubarray(new int[] { 1,-6,3,2,8,-7,1,3 }, ref time);

            Assert.AreEqual(13, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void LenghtOfLastWordInputNull()
        {
            int time = 0;
            int actual = code.LenghtOfLastWord(null, ref time);

            Assert.AreEqual(0, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void LenghtOfLastWordNotMapping()
        {
            int time = 0;
            int actual = code.LenghtOfLastWord("asdfasdf", ref time);

            Assert.AreEqual(0, actual);
            Console.WriteLine(time);
        }

        [TestMethod]
        public void LenghtOfLastWord()
        {
            int time = 0;
            int actual = code.LenghtOfLastWord("Hello World", ref time);

            Assert.AreEqual(5, actual);
            Console.WriteLine(time);
        }

    }
}
