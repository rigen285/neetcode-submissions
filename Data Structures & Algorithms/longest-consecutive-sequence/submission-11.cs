public class Solution {
public int LongestConsecutive(int[] nums) {
        HashSet<int> hash = new HashSet<int>();
        int max = 0; 

        foreach(int num in nums)
            {
                hash.Add(num);
            }

            foreach(int num in hash)
            {
                 int length = 1;
                if(!hash.Contains(num - 1)){
                    while (hash.Contains(num + length))
                        {
                            length++;
                        }
                }
                max = max>length? max:length;
            }
            return max;
    }
}
