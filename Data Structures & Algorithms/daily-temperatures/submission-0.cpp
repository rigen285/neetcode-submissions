class Solution {
public:
    vector<int> dailyTemperatures(vector<int>& temperatures) {
    stack <int> stack;
    vector<int> dailyTemperature(temperatures.size());
    
    for(int i=0; i<temperatures.size();i++){

        while (!stack.empty() && temperatures[i] > temperatures[stack.top()]){
            
            dailyTemperature[stack.top()] = i-stack.top();
            stack.pop();

        }
        stack.push(i);
    }
    return dailyTemperature;
        
}
};
