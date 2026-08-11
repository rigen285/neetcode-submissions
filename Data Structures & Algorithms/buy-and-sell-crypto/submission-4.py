class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        profit_highest = 0
        l,r = 0,1
        while r<len(prices):
            if(prices[r]<prices[l]):
                l=r
                r+=1
            else:
                profit = prices[r] - prices[l]
                profit_highest = max(profit,profit_highest)
                r+=1
        return profit_highest