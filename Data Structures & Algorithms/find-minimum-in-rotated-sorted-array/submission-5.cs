public class Solution {
    public int FindMin(int[] nums) {
        int min = 0;
        int max = nums.Length -1;

        while(min<max){
            int mid = min + (max - min)/2;
                if(nums[mid]>nums[max]) min = mid+1;
                else max = mid   ;

        }
        return nums[min];
    }
}
