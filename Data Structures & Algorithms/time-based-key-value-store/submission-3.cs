public class TimeMap {
        private Dictionary <string,List<(int time, string value)>> tMap;

    public TimeMap(){
        tMap = new Dictionary<string, List<(int time, string value)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!tMap.ContainsKey(key)){
            tMap.Add(key, new List<(int,string)>());
        }
            tMap[key].Add((timestamp,value));
    }
    
    public string Get(string key, int timestamp) {
        if(!tMap.ContainsKey(key)){
            return "";
        }
        
        int left = 0;
        int right = tMap[key].Count -1;
        string res ="";
        while (left<=right){
            int mid = left + (right - left)/2;
            if(tMap[key][mid].time == timestamp) return tMap[key][mid].value;
            else if(tMap[key][mid].time > timestamp) {
                
                
                right = mid-1;
                
            }
            else{left = mid+1;
            res = tMap[key][mid].value;
            }
        }

        return res;
    }
}


