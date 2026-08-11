public class Solution {
    public bool IsSubsequence(string s, string t) {
        int ls = 0;
        int lt = 0;

        while (ls<s.Length && lt<t.Length){
            if(s[ls] == t[lt]){
                ls++;
            }
            lt++;
        }

        return ls == s.Length;
    }
}