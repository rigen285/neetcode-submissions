public class Solution {
public int MinEatingSpeed(int[] piles, int h) {
            int min = 1;
            int max = Max(piles);
            int answer = max;
            
            
            while(min<=max){
                int mid =(min+max)/2;
                long currentTime = Hours(piles,mid);

                if(currentTime<=h){
                    answer = mid;
                    max=mid-1;
                }
                else{
                    min = mid+1;
                }
            }
            return answer;
    }

    public long Hours(int [] piles, int speed)
        {
            long hours =0;

            foreach (int pile in piles)
            {
                hours += pile/speed;
                if(pile % speed != 0) hours++;
            }
            return hours;

        }

    public int Max(int [] array)
        {
            int max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                max = max>array[i]?max:array[i];
            }

            return max;

        }
}
