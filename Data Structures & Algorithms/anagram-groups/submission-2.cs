public class Solution {
 public  List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary <string,int> dict = new Dictionary<string,int>();
        List <List<string>> aswer = new List <List<string>> ();
        int i = 0;
        foreach(string str in strs){
                if(dict.ContainsKey(SortedStr(str))){
                        aswer[dict[SortedStr(str)]].Add(str);       
                }
                else{
                        dict.Add(SortedStr(str),i);
                        aswer.Add(new List<string> {str});
                        i++;
                }
                
        }
            
        return aswer;


        }

        public string SortedStr(string str) {

            char [] chs = str.ToCharArray();
            Array.Sort(chs);
            str = new string(chs);

            return str;
        }

}
