public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0;
        HashSet <char> hash = new  HashSet<char>();
        int res =0;
        for(int r=0; r<s.Length;r++){
                while (hash.Contains(s[r]))
                {
                    hash.Remove(s[l]);
                    l++;
                }

                hash.Add(s[r]);
                res = Math.Max(res,r-l+1);
        }
        return res;
    }
}
