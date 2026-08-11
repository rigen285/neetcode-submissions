public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0;
        int r = s.Length -1;

            while (l < r)
            {
                while (l<r && !char.IsLetterOrDigit(s[r])) r--;
                while(l<r && !char.IsLetterOrDigit(s[l])) l++;

                if(Char.ToLower(s[r]) != Char.ToLower(s[l])) return false;
                else
                {
                    r--;
                    l++;
                }
            }

            return true;
    }
}
