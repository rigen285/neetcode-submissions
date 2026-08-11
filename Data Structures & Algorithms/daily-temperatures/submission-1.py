class Solution:
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        answer = [0] * len(temperatures)
        stack = []
        for i,temp in enumerate(temperatures):
                while stack and temp > stack[-1][1]:
                    ind,tempP = stack.pop()
                    answer[ind] = i - ind
                stack.append((i,temp))
        return answer
