public class Solution {
             public  int[] TopKFrequent(int[] nums, int k) {
            Dictionary <int,int> dict = new Dictionary<int, int>();
            List<int>[] buckets = new List<int>[nums.Length + 1];
            int[] answer = new int[k];
            foreach (int num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict[num] = 1;
                }
                else
                {
                    dict[num]++;
                }
            }
            
            
            foreach(var pair in dict)
            {
                if(buckets[pair.Value] == null)
                {
                    buckets[pair.Value] = new List<int>();
                }
                buckets[pair.Value].Add(pair.Key);
            }

            

            for(int i = buckets.Length-1; i>=0 && k>0;i--)
            {
               if(buckets[i] == null) {continue;}
               
               foreach(int num in buckets[i])
                {
                    answer [k-1] = num;
                    k--;
                    if(k<0){break;}
                }

            }
            
            return answer;
            
         }
}
