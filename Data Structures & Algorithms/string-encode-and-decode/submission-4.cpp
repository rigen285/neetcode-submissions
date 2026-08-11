class Solution {
public:

    string encode(vector<string>& strs) {
    string encoded = "";
    char num2Char;

    for (string str : strs) {
            encoded = encoded + str + '\n';
    }
    return encoded;
}

vector<string> decode(string s) {
    vector<string> strs;
    int left = 0;
    int right = 0;
    string str;
    while (right != s.size() ){

        if (s[right] == '\n' ) {
            str = s.substr(left,right-left);
            strs.push_back(str);
            str = "";
            right++;
            left = right;
            continue;
        }
        right++;
    }

    return strs;
}
};
