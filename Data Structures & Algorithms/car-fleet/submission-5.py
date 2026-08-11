class Solution:
    def carFleet(self, target: int, position: List[int], speed: List[int]) -> int:
        array = []
        stack = []
        for i in range(len(position)):
            array.append((position[i],speed[i]))
        array.sort(reverse=True)
        for pos,speed in array:
                if not stack:
                    stack.append((pos,speed))
                else:
                        s_pos,s_speed = stack[-1]
                        delta_pos = pos - s_pos
                        delta_speed = s_speed - speed
                        if delta_speed<0:
                            t = delta_pos/delta_speed
                            if(t*s_speed + s_pos) <= target:
                                    continue
                        stack.append((pos,speed))
        return len(stack)
        