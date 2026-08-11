class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        l = 0
        h = len(matrix) * len(matrix[0]) - 1

        while(l<=h):
            mid = l + (h-l)//2
            row = mid // len(matrix[0])
            column = mid % len(matrix[0])

            if matrix[row][column] == target:
                return True
            elif matrix[row][column] > target:
                h = mid - 1
            else:
                l = mid + 1
        return False

        