using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> Operations class </summary>
    public class Operations
    {
        /// <summary> Returns largest int from list </summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
                return 0;

            int max = nums[0];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }
            return max;
        }       
    }
}