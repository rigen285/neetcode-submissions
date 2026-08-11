public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int n= nums.Length;
        Dictionary<int,int> dict = new Dictionary<int,int>();
        List<int> [] buckets = new List<int>[n+1];
        List<int> answer = new List<int>();


        foreach(int num in nums){
            if(!dict.ContainsKey(num)){
                dict.Add(num,1);
            }
            else dict[num]++;
        }

        foreach(var key in dict.Keys){
            int i = dict[key];
            if(buckets[i] == null){
                buckets[i] = new  List<int>();
            }
            buckets[i].Add(key);
        }

        for(int i=n; i>=0 && answer.Count<k; i--){
            if(buckets[i] != null){
            answer.AddRange(buckets[i]);
            }
        }


        return answer.Take(k).ToArray();
    }
}
