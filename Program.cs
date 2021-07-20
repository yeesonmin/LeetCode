using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] answer = TwoSum(nums, target);
            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }

        public static int[] TwoSum(int[] nums, int target) {
        
        int[] answer = new int[2];
            for(int i = 0 ; i < nums.Length; i++){
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] ==target){
                        answer[0] = i;
                        answer[1] = j;
                        break;
                    }
                }

            }
            return answer;
    }
    }
}
