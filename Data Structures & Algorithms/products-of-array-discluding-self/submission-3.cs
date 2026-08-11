public class Solution {
                public int[] ProductExceptSelf(int[] nums) {
         
        int sum = 1;
        int[] prodOfArr = new int[nums.Length];
        int isZero = 0;

        foreach (int num in nums){
            if (num == 0) {
                isZero ++;
                continue;
            }
            sum*=num;
        }

        if(isZero>1){sum = 0;}

        for(int i=0; i<nums.Length;i++){
            if(nums[i] == 0){
              prodOfArr[i]=sum;  
            }
            else if(isZero == 1){
                prodOfArr[i] =0;
            }
            else{
            prodOfArr[i]=sum/nums[i];
            }
        }
    return prodOfArr;
            }
}

