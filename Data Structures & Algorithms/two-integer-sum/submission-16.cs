public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int,int> dict = new Dictionary <int, int>();
        int val;
        for (int i=0; i<nums.Length; i++){
            val = nums[i];
            if(dict.ContainsKey(target - val)){
                return new int [] {dict[target - val],i};
            }
            else{
                dict[val] = i;
            }
        }
                    return new int [] {-1,-1};
    }
}
