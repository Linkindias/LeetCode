using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
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
            if (nums == null) return string.Empty;

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

            if (input == null) return 0;

            if (-65534 <= input && input <= 65536)
            {
                int num = input < 0 ? -1 : 1;
                var chars = input.ToString().ToCharArray();
                chars[0] = char.IsDigit(chars[0]) ? chars[0] : ' ';
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
            if (input.ToString().Length == 1) return false;

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

                if (input.Length > 0 && dicRomanMulti.Any(o => !input.Contains(o.Key)) &&
                    dicRomanSingle.Any(o => !input.Contains(o.Key)))
                {
                    input = string.Empty;
                    number = 0;
                }
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

        public string LongestCommonPrefix(string[] inputs, ref int time)
        {
            if (inputs == null) return string.Empty;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            string result = string.Empty;
            bool IsBreak = false;
            Array.Sort(inputs, (x, y) => x.Length.CompareTo(y.Length)); //sort 小至大

            for (int i = 0; i < inputs[0].Length; i++)
            {
                string compareKey = inputs[0].Substring(0, i + 1);

                //Parallel.For(1, inputs.Length, (index, loopState) => //更慢50
                //{
                //    if (!inputs[i].StartsWith(compareKey))
                //    {
                //        result = compareKey.Substring(0, i);
                //        IsBreak = true;
                //        loopState.Stop();
                //    }
                //});
                for (int j = 1; j < inputs.Length; j++)
                {
                    if (!inputs[j].StartsWith(compareKey))
                    {
                        result = compareKey.Substring(0, i);
                        IsBreak = true;
                        break;
                    }
                }

                if (IsBreak) break;
            }

            stopWatch.Stop();
            time = stopWatch.Elapsed.Milliseconds;
            return result;
        }

        public bool ValidParentheses(string input, ref int time)
        {
            if (input == null || input.Length % 2 != 0) return false;

            Dictionary<char, int> disCharacters = new Dictionary<char, int>();
            disCharacters.Add('(', 1);
            disCharacters.Add(')', -1);
            disCharacters.Add('[', 2);
            disCharacters.Add(']', -2);
            disCharacters.Add('{', 3);
            disCharacters.Add('}', -3);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int number = 0;
            for (int i = 0; i < input.Length ; i++)
            {
                number += disCharacters[input[i]];
            }
            stopWatch.Stop();
            time = stopWatch.Elapsed.Milliseconds;

            return number == 0;
        }
    }
}
