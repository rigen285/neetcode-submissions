class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        l,r = 0,len(s1)-1
        if len(s1) > len(s2):
            return False
        comp1 = [0] * 26
        comp2 = [0] * 26

        for i in range(len(s1)):
            comp1[ord(s1[i]) - ord('a')] += 1
            comp2[ord(s2[i]) - ord('a')] += 1
        
        while r<len(s2):
            if comp1 == comp2:
                return True
            else:
                comp2[ord(s2[l]) - ord('a')] -= 1
                l +=1
                r +=1
                if r<len(s2):
                    comp2[ord(s2[r]) - ord('a')] += 1
        return False