public class Solution {
    public bool IsPalindrome(string s) {
        int n = s.Length;
        int i =0;
        int j=n-1;

            while (i < j)
            {
                while(!char.IsLetterOrDigit(s[i]) && i<j) i++;
                while(!char.IsLetterOrDigit(s[j]) && i<j) j--;
                if(i>=j) break;

                if(char.ToLower(s[i]) != char.ToLower(s[j]))
                {
                    return false;
                }

                i++;
                j--;

            }
            return true;
    }
}
