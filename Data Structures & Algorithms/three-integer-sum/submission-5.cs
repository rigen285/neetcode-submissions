public class Solution {
  

        public List<List<int>> ThreeSum(int[] nums) {

        Array.Sort(nums);
        List <List<int>> answer = new List<List<int>>();

        for (int i = 0; i<nums.Length; i++){
            if(i>0){
                if(nums[i] == nums[i-1]) continue;
            }
            twsum(i, nums,answer);
        }

        return answer;
    }

    public void twsum(int index, int[] nums, List <List<int>> answer){
        int firstItem = nums[index];

        int l =index +1;
        int r = nums.Length -1;

        while(l<r){
            int sum = nums[r] + nums[l];
             if(sum + firstItem == 0){
                answer.Add(new List<int>{firstItem,nums[l],nums[r]});
                r--;
                l++;
                while(l<r && nums[r] == nums[r+1]) r--;
                while(l<r && nums[l] == nums[l-1]) l++;
             }

            else if(sum + firstItem > 0) r--;
                else l++;

        }

    }
    }


