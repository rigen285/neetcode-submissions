public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int low = 0;
        int high = matrix.Length * matrix[0].Length - 1;

        int mid;

        while (low<=high){
            mid =(low+high)/2;
            int row = mid/matrix[0].Length;
            int col = mid%matrix[0].Length;

            if(matrix[row][col] == target)return true;
            else if(matrix[row][col] > target) {
                high = mid -1;
            }
            else{
                 low = mid +1;
            }
        }
        return false;
    }
}
