class Solution {
public:
    int maxArea(vector<int>& height) {

        int right = height.size()-1;

        int left = 0;

        int maxArea = 0;

        int area=0;


 

        while (left != right){

            area = (right - left) * min(height[left], height[right]);

            maxArea = area>maxArea ? area:maxArea;

 

            if( height[right]> height[left])

            {

                left++;

            }

            else{right--;}

        }

 

        return maxArea;

    }
};
