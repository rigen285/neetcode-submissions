class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        map <int,int> int2Index;
        int index1;
        int index2;


        for(int i=0; i<nums.size();i++){
            if(int2Index.find(target - nums[i]) != int2Index.end()){
                
                    index1 = int2Index[target - nums[i]];
                    index2 = i;
                    break;
            }
            else{
            int2Index[nums[i]] = i;
            }
        }


        return {index1,index2};
    }
};
