public class Solution {
public int[] Intersection(int[] nums1, int[] nums2) {
       HashSet<int> hash = new  HashSet<int>(nums1);
       HashSet<int> answer = new  HashSet<int>();

       foreach (int num in nums2){
        if(hash.Contains(num)) answer.Add(num);
       }

       return answer.ToArray();

}
}