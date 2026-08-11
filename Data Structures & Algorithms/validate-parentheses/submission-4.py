class Solution:
    def isValid(self, s: str) -> bool:
        my_stack = []
        my_dict = {}
        my_dict[')'] = '('
        my_dict[']'] = '['
        my_dict['}'] = '{'
        for char in s:
            if char ==']' or char =='}' or char ==')':
                if not my_stack or my_stack[-1] != my_dict[char]:
                    return False
                else:
                    my_stack.pop()
            else:
                my_stack.append(char)
        return not my_stack