public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
            Array.Sort(nums);
            int n = nums.Length;
            List<List<int>> answer = new List<List<int>>();

            for(int i =0; i < n; i++)
            {
                if(i>0 && nums[i]==nums[i-1]) {
                    continue;
                }
                int target = -nums[i];
                twosumsum(i,nums,target, n,answer);
            }
            return answer;
            
    }

        public void twosumsum(int i,int [] nums,int target,int n,List<List<int>> answer)
        {
            int left =i+1;
            int right = n-1;

            while (left < right)
            {
                
                int rightNum = nums[right];
                int leftNum = nums[left];
                int sum = rightNum+leftNum;

                if(sum == target)
                {
                    answer.Add(new List<int>{-target,leftNum,rightNum});
                    right--;
                    left++;

                    while(left<right && nums[left] == nums[left-1]) left++;
                    while(left<right && nums[right] == nums[right+1]) right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else if (sum > target)
                {
                    right--;
                }
            }
        }

}
