public class Solution {
public int[] Intersection(int[] nums1, int[] nums2) {
       int i = 0;
       int j = 0;

       Array.Sort(nums1);
       Array.Sort(nums2);

       List<int> answer = new List <int>();

       while(i<nums1.Length && j<nums2.Length){

              if(nums1[i] == nums2[j]){ 
                     answer.Add(nums1[i]);
                     int temp = nums1[i];
                     while(i<nums1.Length && nums1[i] == temp) i++;
                     while(j<nums2.Length && nums2[j] == temp) j++;
                     }

                     else if(nums1[i] > nums2[j]) j++;
                     else i++;

       }
       return answer.ToArray();
}
}