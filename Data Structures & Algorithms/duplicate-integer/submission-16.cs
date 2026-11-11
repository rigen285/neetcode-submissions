public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet <int> hash = new HashSet<int>(nums);
        return hash.Count != nums.Length;
    }
}