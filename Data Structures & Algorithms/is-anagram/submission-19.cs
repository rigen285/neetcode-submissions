public class Solution {
    public bool IsAnagram(string s, string t) {
        return (freq(s)==freq(t));
    }

    public string freq(string str){
        int [] arr = new int [26];
        foreach(char ch in str){
            arr[ch - 'a'] ++;
        }
        return string.Join(',',arr);
    }
}

