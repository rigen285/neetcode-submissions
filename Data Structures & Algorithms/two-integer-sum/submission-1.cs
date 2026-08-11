public class Solution {
    public int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> hash = new Dictionary<int, int>();
    int[] array = new int[2];

    for (int i = 0; i < nums.Count(); i++)
    {
        if (hash.ContainsKey(target - nums[i]))
        {
            
            array[0] = hash[target - nums[i]];
            array[1] = i;
        }
        else
        {
            hash.Add(nums[i], i);
        }
    }
    return array;

}
}

