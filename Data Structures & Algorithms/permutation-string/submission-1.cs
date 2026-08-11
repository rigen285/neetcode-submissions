public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        if (s1.Length > s2.Length) return false;


        int [] s1Count = new int [26];
        int [] s2Count = new int [26];
        
        for (int i =0; i < s1.Length; i++)
            {
                s1Count[s1[i] - 'a']++;
                s2Count[s2[i] - 'a']++;
            }

        int matches = 0;

        for(int j = 0; j < 26; j++)
            {
                if(s1Count[j] == s2Count[j]) matches++;
            }

            int l = 1;

        for(int r = s1.Length; r < s2.Length; r++)
            {
                if(matches == 26)
                {
                    return true;
                }
                else
                {
                    

                    if(s2Count[s2[l-1] -'a'] == s1Count[s2[l-1] - 'a']) matches --;
                    s2Count[s2[l-1] - 'a'] --;
                    if(s2Count[s2[l-1] -'a'] == s1Count[s2[l-1] - 'a']) matches ++;


                    
                    if(s2Count[s2[r] - 'a'] == s1Count[s2[r] - 'a']) { matches --;}
                    s2Count[s2[r] - 'a'] ++;
                    if(s2Count[s2[r] - 'a'] == s1Count[s2[r] - 'a']) { matches ++;}  
                }
                l++;
            }

            return matches == 26;

    }
}
