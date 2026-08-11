public class Solution {
    public bool IsAnagram(string s, string t) {
        return (freq(s)==freq(t));
    }
    public string freq(string s){
        int [] frqarray = new int [26];
        foreach(char ch in s){
            frqarray[ch-'a'] ++;
        }
        return string.Join(',',frqarray);
    }
}
