public class Solution {
public bool IsAnagram(string s, string t) {
        if(t.Length != s.Length) return false;

        Dictionary <char,int> dict = new Dictionary<char, int>();

        foreach(char ch in s)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else dict.Add(ch,1);
            }

            foreach(char ch in t)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] --;

                    if(dict[ch]<0) return false;
                }
                else return false;
            }
            return true;
    }
}
