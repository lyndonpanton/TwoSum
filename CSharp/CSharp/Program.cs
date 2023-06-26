using System;

namespace CSharp
{
    public class Solution
    {

        static void Main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine("----------------");

            int[] testNums = new int[4] { 2, 7, 11, 15 };
            int testTarget = 9;

            Console.WriteLine("Output for array { "
                + String.Join(", ", testNums) + " } and target " + testTarget
                + ": { "
                + String.Join(", ", solution.TwoSum(testNums, testTarget)) + " }"
            );

            Console.WriteLine("----------------");

            testNums = new int[3] { 3, 2, 4 };
            testTarget = 6;

            Console.WriteLine("Output for array { "
                + String.Join(", ", testNums) + " } and target " + testTarget
                + ": { "
                + String.Join(", ", solution.TwoSum(testNums, testTarget)) + " }"
            );
            
            Console.WriteLine("----------------");

            testNums = new int[2] { 3, 3 };
            testTarget = 6;

            Console.WriteLine("Output for array { "
                + String.Join(", ", testNums) + " } and target " + testTarget
                + ": { "
                + String.Join(", ", solution.TwoSum(testNums, testTarget)) + " }"
            );

            Console.WriteLine("----------------");
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] sum = new int[2];
            bool found = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (found) break;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        sum[0] = i;
                        sum[1] = j;

                        found = true;
                        break;
                    }
                }
            }

            return sum;
        }
    }
}