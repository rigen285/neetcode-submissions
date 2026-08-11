public class Solution {
 public int[] ProductExceptSelf(int[] nums) {
            int n=nums.Length;
            int [] product = new int [nums.Length];

            int left = 1;
            for(int i=0; i < n; i++)
            {
                product[i] = left;
                left = nums[i]*left;
            }

            int right = 1;
            for(int j=n-1;j >= 0; j--)
            {
                product[j] = right*product[j];
                right = nums[j] * right;
            }

            return product;
    }
}
