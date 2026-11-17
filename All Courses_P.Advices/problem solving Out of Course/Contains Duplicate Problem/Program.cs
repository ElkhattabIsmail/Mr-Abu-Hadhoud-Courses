using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_Duplicate_Problem
{
//    Input: nums = [1, 2, 3, 3]

//Output: true

//Example 2:

//Input: nums = [1, 2, 3, 4]
    internal class Program
    {
        static bool Contains_Duplicate(int[] nums)
        {
            Dictionary<int,int> Dict = new Dictionary<int,int>();
            foreach (int num in nums)
            {
                if (Dict.ContainsKey(num))
                    return true;
                else 
                    Dict.Add(num, 0);
            }
            return false;
        }

        // Faster in practice (slightly)
        static bool Contains_Duplicate2(int[] nums) 
        {
            HashSet<int> seen = new HashSet<int>();
            foreach (int num in nums)
            {
                if (!seen.Add(num))  // Add returns false if num already exists
                    return true;
            }
            return false;
        }
        static bool Contains_Duplicate3(int[] nums)
        {
            HashSet<int> seen = nums.ToHashSet();
            return nums.Length > seen.Count;
        }


        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            var IsContainDuplicate = Contains_Duplicate2(nums);

            Console.WriteLine(IsContainDuplicate ? "Array Contains Duplicates" : "No Duplicates");
        }
    }
}
