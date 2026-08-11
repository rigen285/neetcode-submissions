public class Solution {
    public bool IsAnagram(string s, string t) {
            if(SortedString(s) == SortedString(t)){
                return true;
            }
            else
            return false;
        }

        public string SortedString(string str)
        {
            char [] chs = str.ToCharArray();
            Array.Sort(chs);
            string sortedString = new string(chs);
            return sortedString;
        }
}
