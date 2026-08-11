public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        int low = 0;

        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int high = rows * cols - 1;

        while (low<=high){
            
            int mid = low + (high - low)/2;
            


            int i = mid/cols;
            int j = mid%cols;

            if(matrix[i][j] == target) return true;
            else if(matrix[i][j] < target) low = mid+1;
            else high = mid -1;


        }

return false;

    }
}
