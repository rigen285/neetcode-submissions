public class Solution {
    public int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> hash = new Dictionary<int, int>();
    int[] array = new int[2];

    for (int i = 0; i < nums.Count(); i++)
    {
        if (hash.ContainsKey(target - nums[i]))
        {
            return new int [] {hash[target - nums[i]],i};
            
        }
        else
        {
            hash.Add(nums[i], i);
        }
    }
    return new int[]{-1,-1};

}
}

