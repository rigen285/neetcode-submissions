class Solution {
public:
    int maxArea(vector<int>& heights) {
        int right = heights.size()-1;
        int left = 0;
        int longest = 0;
        int length;
        int temp;
        while(left <right){

            length = right - left;
            temp = min(heights[left],heights[right])*length;

            longest = longest<temp? temp:longest;

            if(heights[left]<heights[right]){
                left++;
            }
            else{right--;}
        }

        return longest;
    }
};
