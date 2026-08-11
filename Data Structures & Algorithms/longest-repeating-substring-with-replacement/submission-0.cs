public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary <char,int> dict = new Dictionary<char,int>();
        int l = 0;
        int r = 0;
        int maxf = 0;
        int res =0;
        
        while(r<s.Length){
            if(!dict.ContainsKey(s[r])) dict.Add(s[r],1);
            else dict[s[r]]++;

            
            
            maxf = Math.Max(dict[s[r]], maxf);

            while(r-l+1 - maxf > k){
                dict[s[l]] --;
                l++;
            }

            res = Math.Max(r-l+1,res);

            r++;
        }

        return res;
    }
}
