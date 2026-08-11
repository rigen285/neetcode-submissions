public class Solution {
public int LongestConsecutive(int[] nums) {
        HashSet <int> hash = new HashSet<int>();

        if(nums.Length == 0) return 0;

        foreach(int num in nums) hash.Add(num);
        int maxfreq = 0;
        foreach(int num in nums)
            {
                int integer = num;
                if (!hash.Contains(num - 1))
                {
                    integer = num+1;
                    while (hash.Contains(integer))
                    {
                        integer++;
                    }
                    if((integer-num)>maxfreq) maxfreq = integer-num;
                }
            }
            return maxfreq;
    }
}
