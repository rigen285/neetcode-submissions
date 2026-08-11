public class Solution {
             public  int[] TopKFrequent(int[] nums, int k) {
            Dictionary  <int,int> dict = new Dictionary<int, int>();

            foreach(int num in nums)
            {
                if(dict.ContainsKey(num)){dict[num]++;}
                else dict.Add(num,1);
            }
            
            var freq = dict.OrderBy(x=>x.Value).TakeLast(k).Select(x=>x.Key).ToArray();
            return freq;
            
         }
}
