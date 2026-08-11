public class Solution {
    public int Search(int[] nums, int target) {

        int low = 0;
        int high = nums.Length -1;
        
        if(target == nums[high]) return high;
        else if (target < nums[high]){
             low = FindMin(nums);
        }
        else{
             high = FindMin(nums) -1;
        }

        while(low<=high){
            int mid = (low+high)/2;
            if(nums[mid] == target) return mid;
            else if (nums[mid] > target) high = mid-1;
            else low = mid+1;
        }
        
        return -1;


    }

public int FindMin(int[] nums) {
        int low = 0;
        int high = nums.Length -1;

        while(low<high){
            int mid = (low + high)/2;
            if(nums[mid]>nums[high]) low = mid +1;
            else high = mid;
        }
    return low;
    
    }

}
