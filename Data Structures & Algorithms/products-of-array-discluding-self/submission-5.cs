public class Solution {
      public  int[] ProductExceptSelf(int[] nums) {
        int[] pre = new int[nums.Length];
        int[] after = new int[nums.Length];
        int[] answer = new int[nums.Length];
        int multsum = 1; 
        for(int i = 0; i < pre.Length; i++)
            {
                if(i == 0)
                {
                     pre[i] = nums[i];
                }
                else
                {
                    pre[i] = multsum * nums[i];
                }
                multsum *= nums[i];
            }

            multsum =1;

            for(int j = after.Length-1; j >=0 ; j--)
            {
                if(j == after.Length-1)
                {
                     after[j] = nums[j];
                }
                else
                {
                    after[j] = multsum * nums[j];
                }
                multsum *= nums[j];
            }

            answer[0] = after[0+1];
            answer[answer.Length - 1] = pre[answer.Length - 2];

            for(int k=1; k < answer.Length-1; k++)
            {
            
                    answer[k] = pre[k-1]*after[k+1];
            }
            return answer;


    }
}
