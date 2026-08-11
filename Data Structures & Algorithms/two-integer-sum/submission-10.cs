public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            Dictionary <int,int> dict = new Dictionary<int, int>();
            int delta;
            int num;
            for(int i=0; i < nums.Length; i++)
            {
                num = nums[i];
                delta = target - num;
                if (!dict.ContainsKey(delta))
                {
                    dict[num] = i;
                }
                else
                {
                    return new [] {dict[delta],i};
                }
            }

            return new [] {-1,-1};
        }
}
