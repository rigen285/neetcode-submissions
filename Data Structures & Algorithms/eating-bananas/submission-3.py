class Solution:
      def minEatingSpeed(self, piles: List[int], h: int) -> int:
        l,r = 1,max(piles)
        res = r

        while l<=r:
            mid = l+(r-l)//2
            accu_hours = 0
            for pile in piles :
                accu_hours += (pile//mid)
                if pile%mid:
                    accu_hours += 1
            if accu_hours <= h:
                res = mid
                r=mid-1
            else:
                 l=mid + 1
        return res  