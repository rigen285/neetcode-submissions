public class Solution {
    public int Search(int[] nums, int target) {
        
        int low = 0;
        int high = nums.Length -1;
        
        int pivot = FindMin(nums);

        if(nums[pivot] == target) return pivot;
        else if (nums[high] < target) high = pivot -1;
        else low = pivot+1;

   

        while(low <= high){
            int mid = low + (high - low)/2;

            if(nums[mid] == target) return mid;
            else if(nums[mid] < target) low = mid+1;
            else high = mid -1;
        }

        return -1;

    }

    public int FindMin(int [] nums){
        int low = 0;
        int high = nums.Length -1;

        while(low<high){
            int mid = low + (high - low)/2;

            if(nums[high] < nums[mid]) low = mid +1;
            else high = mid;
        }

        return low;
    }
}
