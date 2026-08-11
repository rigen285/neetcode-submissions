class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
        map<int,int> numIndex;

        for (int i =0; i<nums.size();i++){
            if(numIndex.find(nums[i]) != numIndex.end()) {return true;}

            else{
                numIndex[nums[i]]=i;
            }
        }

        return false;

    }
};