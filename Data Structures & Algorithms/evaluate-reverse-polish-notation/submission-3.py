class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stack = []
        answer = 0
        for char in tokens:
            if char in {"+", "-", "*", "/"}:
                second = stack.pop()
                first = stack.pop()
                if char == '+':
                    stack.append(first + second)
                elif char == '-':
                    stack.append(first - second)
                elif char == '*':
                    stack.append(first * second)
                elif char == '/':
                    stack.append(int(first / second))
            else:
                stack.append(int(char))
        return stack.pop()