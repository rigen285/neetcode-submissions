public class Solution {
      public  int[] ProductExceptSelf(int[] nums) {
        int right = 1;
        int left = 1;
        int n = nums.Length;
        int [] answer = new int[n];

        for(int i=0; i<n; i++)
            {
                answer[i] = left;
                left *= nums[i];
            }

        for(int j = n-1; j >= 0; j--)
            {
                answer[j] *= right;
                right *= nums[j]; 
            }

        return answer;
    }
}
