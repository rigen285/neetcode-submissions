public class Solution {
 public  List<List<string>> GroupAnagrams(string[] strs) {
            List <List<string>> listOfAnns = new List<List<string>> ();
            Dictionary <string,int> dict = new Dictionary<string, int>();
            string temp;
            int i = 0;
            foreach (string str in strs)
            {
                temp = GetSortedString(str);
                if (dict.ContainsKey(temp))
                {
                    listOfAnns[dict[temp]].Add(str);
                }
                else
                {
                    dict[temp] = i;
                    listOfAnns.Add(new List<string>(){str});
                    i++;
                }
            }
            return listOfAnns;
        }
        public  string GetSortedString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            str = new string(charArray);
            return str;
        }
}
