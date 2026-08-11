public class Solution {
    public bool IsAnagram(string s, string t) {
            Dictionary <char,int> dict = new Dictionary<char, int>();

            if(s.Length != t.Length)
            {
                return false;
            }

            foreach(char ch in s)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch,1);
                }
                else
                {
                    dict[ch]++;
                }
            }

            foreach (char ch in t)
            {
                if(!dict.ContainsKey(ch))return false;
                else dict[ch] --;

                if(dict[ch] < 0) return false;
            }

            return true;
        }
}
