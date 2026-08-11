class Solution {
public:
    bool isValid(string s) {
        stack <char> charStrack;


        for(int i=0;s[i];i++){
            if(s[i] == '(' || s[i] == '{' || s[i] == '['){
                charStrack.push(s[i]);
            }
            else if(charStrack.empty()){
                return false;
            }

            else if((s[i] == ')' && charStrack.top() == '(') || (s[i] == ']' && charStrack.top() == '[') || (s[i] == '}' && charStrack.top() == '{')){
                charStrack.pop();
            }
            else{
                return false;
            }
            
        }
        return charStrack.empty();
    }
};
