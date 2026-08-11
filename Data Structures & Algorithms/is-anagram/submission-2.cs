public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary <char,int> hash = new Dictionary<char, int>(); 

        if(s.Count() != t.Count()){
            return false;
        }

        foreach (char ch in s){
            if(hash.ContainsKey(ch)){
                hash[ch]++;
            }
            else hash.Add(ch,1);
        }

        foreach (char ch in t){
            if(hash.ContainsKey(ch)){
                hash[ch]--;
                
            }
            else return false;

            if(hash[ch]<0) return false;
        }

        return true;

    }
}
