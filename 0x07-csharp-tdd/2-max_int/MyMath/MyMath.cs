using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Creates operations</summary>
    public class Operations
    {
        ///<summary>Returns the max intager in a list</summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count < 1)
        {
            Console.WriteLine("List is empty");
            return 0;
        }

        nums.Sort();
        return nums[nums.Count - 1];
        }
    }
}
