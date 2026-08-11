class Solution {
public:
    int longestConsecutive(vector<int>& nums) {

        if(nums.empty()) {return 0;}

        int longest = 1;
        int count = 1;
        sort(nums.begin(), nums.end());

        for (int i =1; i<nums.size(); i++){
            if(nums[i] - nums[i-1] == 1)
            {
                count++;
                longest = longest<count?count:longest;
            }

            else if(nums[i] != nums[i-1]) 
            {count =1;}
        }
        

        return longest;
    }
};
