public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet <int> hashset = new HashSet<int>();

        foreach(int num in nums){
            if(hashset.Contains(num)){
                return true;
            }
            else{
                hashset.Add(num);
            }
        }
        return false;
    }
}