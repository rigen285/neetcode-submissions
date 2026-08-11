class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        dict = {}
        buckets = [[]  for i in range(len(nums)+1)]
        answer = []
        for num in nums:
                dict[num] = 1 + dict.get(num,0)
        for num in dict.keys():
            buckets[dict[num]].append(num)
        for bucket in reversed(buckets):
            if len(answer)>k:
                break
            answer += bucket
        while len(answer) > k:
            answer.pop()
        return answer
        