public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int n=nums.Length;
        
        List<List<int>> answer = new List<List<int>> ();
        for(int i=0; i<n;i++){
            if(i>0){
               if(nums[i] == nums[i-1]) continue;
            }
            twosum(answer,i,nums);
        }
        return answer;
    }
public void twosum(List<List<int>> answer,int i,int[] nums){
    int left = i+1;
    int right = nums.Length -1;
    int target = 0-nums[i];
    while(left<right){
        int sum = nums[right]+nums[left];
        
        if(sum == target){
            answer.Add(new List<int>{nums[i],nums[left],nums[right]});
            left ++;
            right--;
            while(left<right && nums[right] == nums[right+1]) right--;
            while(left<right && nums[left] == nums[left-1]) left++;
        }
        else if(sum>target){
            right --;
        }
        else{left ++;}
    }
}

}
