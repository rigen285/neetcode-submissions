public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary <int,int> dict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int  diff = target - num;
                if(dict.ContainsKey(diff)) return new int []{dict[diff],i};
                else dict.Add(num,i);
            }
        return new int[]{-1,-1};
    }
}
