public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int,int> dict = new Dictionary<int,int>();
        int num;
        for(int i=0; i<nums.Length;i++){
            num=nums[i];
            if(dict.ContainsKey(target - num)){
                return new [] {dict[target-num],i};
            }
            else{
                dict.Add(nums[i],i);
            }
        }

        return new [] {-1,-1};

    }
}
