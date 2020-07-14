using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    public class LeetCode
    {
        public string TwoSum(int[] ints, int target)
        {
            if (ints.Length == 0) return "";

            var lsRemain = new List<int>();
            for (var i = 0; i < ints.Length; i++)
            {
                var key = target - ints[i];
                if (lsRemain.Any(o => o == ints[i])) return $"{lsRemain.IndexOf(ints[i])},{i}";
                lsRemain.Add(key);
            }

            return "Not Find";
        }
    }
}