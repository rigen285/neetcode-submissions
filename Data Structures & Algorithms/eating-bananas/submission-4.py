class Solution:
      def minEatingSpeed(self, piles: List[int], h: int) -> int:
        l,r = 1,max(piles)
        res = r

        while l<=r:
            mid = l+(r-l)//2
            accu_hours = 0
            accu_hours += sum((pile+mid-1)//mid for pile in piles)
            if accu_hours <= h:
                res = mid
                r=mid-1
            else:
                 l=mid + 1
        return res  