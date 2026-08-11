class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
    vector <vector<string>> sublists;
    map<string, int> strMap;
    string unsortedStr;
    int index;
    int count = 0;
    for (int i = 0; i < strs.size();i++) {
        unsortedStr = strs[i];
        sort(strs[i].begin(), strs[i].end());
        if (strMap.find(strs[i]) == strMap.end()) {
            strMap[strs[i]] = count;
            count++;
            sublists.resize(count);
        }
        
        index = strMap.at(strs[i]);
        sublists[index].push_back(unsortedStr);

    }

    return sublists;
}
};
