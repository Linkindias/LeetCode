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
    }
}
