class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        l = 0
        r = 0
        count_dict = {}
        maxf = 0
        res = 0

        while (r<len(s)):
            count_dict [s[r]] = 1 + count_dict.get(s[r],0)
            maxf = max(count_dict[s[r]],maxf)
            while r-l+1-maxf > k:
                count_dict[s[l]] -= 1
                l += 1
            res = max(r-l+1,res)
            r += 1
        return res





        