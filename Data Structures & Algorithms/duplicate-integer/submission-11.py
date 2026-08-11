class Solution:
    def hasDuplicate(self,nums:List[int]) -> bool:
        hash = set()
        for val in nums:
            if val not in hash:
                hash.add(val)
            else:
                return True
        return False     
        