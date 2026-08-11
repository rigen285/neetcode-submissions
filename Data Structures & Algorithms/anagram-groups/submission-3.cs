public class Solution {
public  List<List<string>> GroupAnagrams(string[] strs) {
            Dictionary<string,int> dict = new Dictionary<string, int>();
            List<List<string>> answr = new List<List<string>>();
            int i = 0;
            int index;
            string sortedString;
            foreach (string str in strs)
            {
                sortedString = SortedString(str);
                if(!dict.ContainsKey(sortedString))
                {
                    dict.Add(sortedString,i);
                    answr.Add(new List<string>(){str});
                    i++;
                }
                else
                {
                    index = dict[sortedString];
                    answr[index].Add(str);
                }
            }
            return answr;
        }

        public string SortedString(string str)
        {
            char [] chs = str.ToCharArray();
            Array.Sort(chs);
            string sortedString = new string(chs);
            return sortedString;
        }

}
