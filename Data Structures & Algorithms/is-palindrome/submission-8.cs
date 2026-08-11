public class Solution {
    public bool IsPalindrome(string s) {
        int l=0;
        int r = s.Length - 1;

            while (l < r)
            {
                if(char.IsLetterOrDigit(s[r]) && char.IsLetterOrDigit(s[l])){
                    if(char.ToLower(s[r]) != char.ToLower(s[l])) return false;
                    else{
                        r--;
                        l++;
                    }
                }
                else{

                
                    while(l<r && !char.IsLetterOrDigit(s[r])) r--;
                    while(l<r && !char.IsLetterOrDigit(s[l])) l++;
                }
                
                
            }
            return true;
    }
}
