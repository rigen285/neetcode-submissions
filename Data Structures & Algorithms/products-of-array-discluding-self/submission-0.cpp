class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        int prodOfElements = 1;
        int countZeroes = 0;
        vector <int> prodOfElementsVec;
        prodOfElementsVec.resize(nums.size());
        for(int num:nums){
            if(num != 0){
            prodOfElements*=num;
            }
            else{
                countZeroes++;

                if(countZeroes>=2){
                    return prodOfElementsVec;
                }
            }
            
            }



            
        for(int i=0; i<prodOfElementsVec.size(); i++){
            if(nums[i] != 0 && countZeroes){
                continue;
            }
            else if(nums[i] == 0){
                prodOfElementsVec[i] =prodOfElements;
            }
            else{prodOfElementsVec[i] = prodOfElements/nums[i];}
            
        }

        return prodOfElementsVec;
    }
};