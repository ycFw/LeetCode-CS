//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 31.3 MB
// Link: https://leetcode.com/submissions/detail/352344600/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    using System.Collections.Generic;

    public class _001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // continue test git reabse
            var dic = new Dictionary<int, int>();
            // do something

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    return new int[] { dic[nums[i]], i };
                else
                    dic[target - nums[i]] = i;
            }

            return new int[] { };
            // test git rebase
        }
    }
}
