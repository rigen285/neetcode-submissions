class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        my_hash = set()
        max_val = 0
        for num in nums:
            my_hash.add(num)
        for num in my_hash:
            length = 1
            temp = num - 1
            while temp in my_hash:
                length += 1
                temp -= 1
            max_val = max(max_val,length)
        return max_val