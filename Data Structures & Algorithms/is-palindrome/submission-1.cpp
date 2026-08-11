class Solution {
public:
    bool isPalindrome(string s) {
        int right = s.length()-1;
        int left =0;

        while(left<right){
            
            if(s[right] == ' ' || (!isdigit(s[right]) && !isalpha(s[right]))){
                right --;
                continue;
            }

            if(s[left] == ' '|| (!isdigit(s[left]) && !isalpha(s[left]))){
                left ++;
                continue;
            }

            if(isalpha(s[left])){
                if(tolower(s[left]) != tolower(s[right])) {return false; }
            }
            else{
                if(s[left] != s[right]){return false;}
            }

            right--;
            left++;
        }

        return true;
    }
};
