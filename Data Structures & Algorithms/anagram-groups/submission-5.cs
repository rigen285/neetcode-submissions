public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary <string,List<string>> dict = new Dictionary<string, List<string>>();
        List<List<string>> answer = new List<List<string>>();
        foreach(string str in strs)
            {
                string frq = Letterfreq(str);
                if (!dict.ContainsKey(frq))
                {
                    dict.Add(frq,new List<string>());
                }
                dict[frq].Add(str);
            }

        foreach(var value in dict.Values)
            {
                answer.Add(value);   
            }
            return answer;
    }

    public string Letterfreq(string str){
            char[] frq = new char[26];

            foreach (char ch in str)
            {
                frq[ch - 'a']++;
            }

            return string.Join(',',frq);
        }
}
