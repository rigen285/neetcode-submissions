public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r= numbers.Length -1;

        while(l<r){
            int leftN = numbers[l];
            int rightN = numbers[r];
            int sum = rightN + leftN;

            if(sum == target)
                return new int [] {l+1,r+1};
            else if(sum > target){
                r--;
            }
            else l++;
        }
        return null;
    }
}
