class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        left = 1
        right =1
        product = [1] * len(nums)
        for i in range(len(nums)):
            product[i] = left
            left = left * nums[i]
        for j in reversed(range(len(nums))):
            product[j] = product[j] *right
            right = nums[j] * right
        return product