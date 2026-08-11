class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
    map <int, int> numMostFreq;
    vector <vector<int>> buckets;
    int j = 0;
    vector<int> answer;
    for (int i = 0; i < nums.size();i++) {
        numMostFreq[nums[i]]++;
    }
    
	buckets.resize(nums.size() +1);

    for (auto pair : numMostFreq) {
        buckets[pair.second].push_back(pair.first);
    }


    int temp;
    for (int i = buckets.size() - 1; i >= 0 && k != 0;i--) {
        while (!buckets[i].empty() && k != 0) {
            temp = buckets[i].back();
            buckets[i].pop_back();
            answer.push_back(temp);
            k--;
        }
    }
    return answer;
}};