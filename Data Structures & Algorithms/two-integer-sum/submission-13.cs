public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int,int> hash = new Dictionary<int,int>();
        int n = nums.Length;
        for(int i=0; i<n;i++){
            int num = nums[i];
            int match = target - num;
            if(hash.ContainsKey(match)){
                return 
                    new int[] {hash[match],i};
                    
            }
            else {
                hash[num] = i;
            }
        }

        return new int[]{-1,-1};

    }
}
