class TimeMap:
    def __init__(self):
        # Initializes the dictionary to store keys and their values
        self.time_map = {} 

    def set(self, key: str, value: str, timestamp: int) -> None:
        # BUG FIX: Added 'self.' to access the instance variable
        if key not in self.time_map:
            self.time_map[key] = [] 
        self.time_map[key].append((value, timestamp)) 

    def get(self, key: str, timestamp: int) -> str:
        if key not in self.time_map:
            return ""
        
        # BUG FIX: Right bound must be the last valid index: len() - 1
        l, r = 0, len(self.time_map[key]) - 1
        res = ""
        
        while l <= r:
            m = l + (r - l) // 2
            # BUG FIX: Changed 'time_map' to 'self.time_map'
            if self.time_map[key][m][1] == timestamp:
                return self.time_map[key][m][0]
            elif self.time_map[key][m][1] < timestamp:
                # This is a potential valid answer, record and look right
                res = self.time_map[key][m][0]
                l = m + 1
            else:
                # Too large, look left
                r = m - 1
                
        return res