public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet <int> hashset = new HashSet<int>();

        foreach(int num in nums){
            if(!hashset.Add(num)){
                return true;
            }
        }
        return false;
    }
}