public class Solution {
public int[] Intersection(int[] nums1, int[] nums2) {
            Array.Sort(nums1);
            Array.Sort(nums2);

            if(nums1.Length >= nums2.Length)
            {
                return inttro(nums1,Unique(nums2));
            }
            else return inttro(nums2,Unique(nums1));
            
        }

        public int [] inttro(int [] nums, HashSet<int> hash)
        {
            List <int> inter = new List<int>();
            foreach (var key in hash)
            {
                if (bSearch(nums,key)){
                    inter.Add(key);
                }
            }
            return inter.ToArray();
        }

        public bool bSearch(int [] nums,int target)
        {
            int low =0;
            int high = nums.Length -1;

            while (low <= high)
            {
                int mid = low + (high-low)/2;
                if(nums[mid] == target) return true;
                else if(nums[mid] > target) high = mid-1;
                else low = mid+1;
            }
            return false;
        }

        public HashSet <int> Unique(int [] nums){
            HashSet <int> hash = new HashSet<int>();
            
            foreach (int num in nums)
            {
                hash.Add(num);
            }
            return hash;
        }
}