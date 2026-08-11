public class Solution {
public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary <string,List<string>> dict = new Dictionary<string, List<string>>();
        List <List<string>> answer = new List<List<string>>();

        
        foreach(string str in strs)
            {
                string freqletter = Letterfreq(str);
                if(!dict.ContainsKey(freqletter)) dict.Add(freqletter,new List<string>{str});
                else dict[freqletter].Add(str);
            }

            foreach(var vals in dict.Values)
            {
                answer.Add(vals);
            }

        return answer;
    }

    public string Letterfreq(string str){
            
            int [] letters = new int[26];

            foreach(char ch in str)
            {
                letters[ch - 'a']++;
            }
            return  String.Join(',',letters);
        }

}
