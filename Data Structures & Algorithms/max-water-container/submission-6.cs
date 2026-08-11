public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int maxArea = 0;
        while(left<right){
            int length = right - left;
            int height = Math.Min(heights[right],heights[left]);
            int area = length*height;

            maxArea = Math.Max(area,maxArea);

            if(heights[right] > heights[left]){
                left++;
            }
            else{
                right --;
            }
        }
        return maxArea;
    }
}
