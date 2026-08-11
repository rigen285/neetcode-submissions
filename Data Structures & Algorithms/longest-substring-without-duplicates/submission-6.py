class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        hash = set()
        l,r = 0,0
        if len(s) == 0:
            return 0
        mas_len = 0
        while(r<len(s)):
            while s[r] in hash:
                hash.remove(s[l])
                l+=1
            hash.add(s[r])
            mas_len = max(mas_len,r-l+1)
            r+=1
        return mas_len


            
        

            

        
        