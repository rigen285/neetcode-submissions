class Solution {
public:
    vector<vector<int>> threeSum(vector<int>& nums) {
        
        vector<vector<int>> answer;

        int left = 0;
        int right;
        int mid;
        vector <int> temp;
        sort(nums.begin(), nums.end());

        while (nums[left]<=0 && left <nums.size() - 2){
            if(left > 0){
                if(nums[left]==nums[left-1])
                    {
                        left++;
                        continue;
                    }
            }

            mid = left+1;
            right = nums.size() - 1;

            while (mid<right){
                if(nums[mid] + nums[right] == abs(nums[left]))
                    {
                        temp.push_back(nums[left]);
                        temp.push_back(nums[mid]);
                        temp.push_back(nums[right]);

                        answer.push_back(temp);

                        temp.clear();

                        int rightTemp = nums[right];
                        
                        while(nums[right] == rightTemp && right>0) {right --;}

                    }

                    else if(nums[mid] + nums[right] > abs(nums[left])){
                        right --;
                    }

                    else {
                        mid++;
                    }
            }

            left ++;

        }

        return answer;
    }
};