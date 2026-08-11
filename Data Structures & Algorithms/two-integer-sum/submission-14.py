class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        dict = {}
        for i,val in enumerate(nums):
            delta = target - val
            if delta in dict:
                return [dict[delta],i]
            dict[val] = i
        return [-1,-1]
        