public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        //Check if length are equal if not return false
        if(s.Length != t.Length) return false;

        //Get Data in to the dictionary
        foreach(char ch in s){
            if(dict.ContainsKey(ch)) {dict[ch]++;}
            else {dict.Add(ch,1);}
        }

        //Validate all anagram
        foreach(char ch in t){
            if(!dict.ContainsKey(ch)){return false;}
            else {dict [ch]--;}

            if(dict[ch] < 0) {return false;}
        }

        return true;
    }
}
