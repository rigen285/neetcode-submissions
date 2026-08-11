class Solution {
public:
    int evalRPN(vector<string>& tokens) {
        stack <int> stk;
        for(int i=0; i<tokens.size(); i++){
            
if (tokens[i].size() == 1 &&
    (tokens[i][0] == '+' || tokens[i][0] == '-' ||
     tokens[i][0] == '/' || tokens[i][0] == '*')) {
                int num2 =stk.top();
                stk.pop();
                int num1 =stk.top();
                stk.pop();
                switch(tokens[i][0]){
                    case '+':
                        stk.push(num1+num2);
                        break;
                    case '-':
                    stk.push(num1-num2);
                    break;
                    case '/':
                    stk.push(num1/num2);
                    break;
                    case '*':
                    stk.push(num1*num2);
                    break;

                }
     }
                else{
                    stk.push(std::stoi(tokens[i]));
                }
            }

            return stk.top();

        }
    
};