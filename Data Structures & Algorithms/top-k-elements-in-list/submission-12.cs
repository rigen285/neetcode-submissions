public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary <int,int> dict = new Dictionary<int,int>();
            List <int> [] arr = new List<int> [nums.Length + 1];
            List <int> answer = new List<int>();
            foreach(int num in nums)
            {
                if(dict.ContainsKey(num)) dict[num]++;
                else dict.Add(num,1);
            }

            int key;
            int value;
            
            foreach(var pair in dict)
            {
                key = pair.Key;
                value = pair.Value;

                if(arr[value] == null)
                {
                    arr[value] = new List<int>();
                }

                arr[value].Add(key);
            }

            for(int i = arr.Length -1; i>=0 && answer.Count < k; i--)
            {
                if(arr[i] != null)
                {
                    answer.AddRange(arr[i]);
                }
            }

            return answer.Take(k).ToArray();
    }
}
