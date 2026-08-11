class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        nums.sort()
        answer = []
        for i in range(len(nums)):
            if i>0 and nums[i] == nums[i-1]:
                continue
            l=i+1
            r=len(nums) - 1
            while(l<r):
                target = 0 - nums[i]
                if nums[l] + nums[r] == target:
                    answer.append([nums[i], nums[l], nums[r]])
                    l +=1
                    r -=1
                    while l<r and nums[l-1] == nums[l]:
                        l += 1
                    while l<r and nums[r+1] == nums[r]:
                        r -=1
                elif nums[l] + nums[r] < target:
                    l += 1
                else:
                    r -= 1
        return answer
            