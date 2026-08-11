public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> answer = new List<List<string>>();
        Dictionary<string,List<string>> dict = new Dictionary<string,List<string>>();

        foreach(string str in strs){
            string angr = freq(str);
            if(!dict.ContainsKey(angr)){
                dict.Add(angr,new List<string>());
            }

            dict[angr].Add(str);
        }

        foreach(var value in dict.Values){
            answer.Add(value);
        }
        return answer;
    }

    public string freq(string str){
        char [] freqarray = new char[26];
        foreach(char ch in str){
            freqarray[ch-'a']++;
        }
        return string.Join(',',freqarray);
    }

}
