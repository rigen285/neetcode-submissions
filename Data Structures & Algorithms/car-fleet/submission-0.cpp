class Solution {
public:
    int carFleet(int target, vector<int>& position, vector<int>& speed) {
        vector <pair<int,int>> pos_speed;

        for(int i = 0; i<position.size();i++){
            pair <int,int> pos_speedPair(position[i],speed[i]);
            pos_speed.push_back(pos_speedPair);
        }

        sort(pos_speed.begin(),pos_speed.end());

        double max_time = -1;
        int fleet_counter = 0;
       
        

       for(int i = pos_speed.size()-1; i >= 0 ; i--){
        double time = (target - pos_speed[i].first)/static_cast<double>(pos_speed[i].second);
        //cout<<"time "<<time <<'\n';
        //cout<<"max "<<max_time <<'\n';
        if(time>max_time){
            fleet_counter++;
            max_time = time;
        }
       }
       return fleet_counter;
    }
};