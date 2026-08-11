public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int min = 1;
        int max = Max(piles);

        int lowestSpeedNeeded = max;

        while(min<=max){
            int mid = min+(max - min)/2;

            if(hour(piles,mid) <= h){
                 lowestSpeedNeeded = mid;
                 max = mid -1;
            }
            else min = mid+1;
        }

        return lowestSpeedNeeded;

    }

    public long hour(int [] piles , int speed){
        long hours = 0;

        foreach(int pile in piles){
            hours += pile/speed;
            if(pile%speed != 0) hours++;
        }
        return hours;
    }

    public int Max(int [] nums){
        int max = nums[0];

        for(int i=1;i<nums.Length;i++){
            max = Math.Max(nums[i],max);
        }
        return max;
    }
}
