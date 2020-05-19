using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace LeetCode
{
    public class LeetCode
    {
        public string TwoSum(int[] nums, int target, ref int time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //二者相加
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (i == j) continue;

            //        if (nums[i] + nums[j] == target)
            //        {
            //            stopWatch.Stop();
            //            time = stopWatch.Elapsed.Milliseconds;
            //            return $"{i},{j}";
            //        }
            //    }
            //}

            //項目清單.index(總數 - 項目)
            List<int> remain = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var key = target - nums[i];
                if (remain.Any(o => o == nums[i]))
                {
                    return $"{remain.IndexOf(nums[i])},{i}";
                }
                remain.Add(key);
            }
            stopWatch.Stop();
            time = stopWatch.Elapsed.Seconds;
            return "not find";
        }

        public int ReverseInteger(int input, ref int time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            if (-65534 <= input && input <= 65536)
            {
                int num = 1;
                var chars = input.ToString().ToCharArray();

                if (chars[0] == '-')
                {
                    num = -1;
                    chars[0] = ' ';
                }
                Array.Reverse(chars);
                int result = int.Parse(string.Join("", chars)) * num;
                stopWatch.Stop();
                time = stopWatch.Elapsed.Seconds;
                return result;
            }
            return 0;
        }

        public bool PalindromeNumber(int input, ref int time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            char[] charNumber = input.ToString().ToCharArray();
            Array.Reverse(charNumber);
            string result = string.Join("", charNumber);
            stopWatch.Stop();
            time = stopWatch.Elapsed.Seconds;
            return result == input.ToString();
        }

        public int RomantoInteger(string input, ref int time)
        {
            Dictionary<string, int> dicRomanSingle = new Dictionary<string, int>();
            dicRomanSingle.Add("I", 1);
            dicRomanSingle.Add("V", 5);
            dicRomanSingle.Add("X", 10);
            dicRomanSingle.Add("L", 50);
            dicRomanSingle.Add("C", 100);
            dicRomanSingle.Add("D", 500);
            dicRomanSingle.Add("M", 1000);
            Dictionary<string, int> dicRomanMulti = new Dictionary<string, int>();
            dicRomanMulti.Add("IV", 4);
            dicRomanMulti.Add("IX", 9);
            dicRomanMulti.Add("XL", 40);
            dicRomanMulti.Add("XC", 90);
            dicRomanMulti.Add("CD", 400);
            dicRomanMulti.Add("CM", 900);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int number = 0;
            while (input.Length > 0)
            {
                input = CompareRoman(input, dicRomanMulti, ref number);
                input = CompareRoman(input, dicRomanSingle, ref number);
            }

            stopWatch.Stop();
            time = stopWatch.Elapsed.Seconds;
            return number;
        }

        private string CompareRoman(string input, Dictionary<string, int> dicRoman, ref int number)
        {
            var romanCompare = dicRoman.Where(o => input.Contains(o.Key)).ToList();
            foreach (var romanrole in romanCompare)
            {
                input = input.Remove(input.IndexOf(romanrole.Key), romanrole.Key.Length);
                number += romanrole.Value;
            }
            return input;
        }
    }
}
