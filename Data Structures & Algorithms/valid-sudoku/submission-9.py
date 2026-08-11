class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
            rows = defaultdict(set)
            boxes = defaultdict(set)
            cols = defaultdict(set)
            for i in range(len(board)):
                for j in range(len(board[i])):
                    if board[i][j] == '.':
                        continue
                    x = i//3
                    y = j//3
                    box = (x,y)
                    if board[i][j] in rows[i] or board[i][j] in cols[j] or board[i][j] in boxes[box]:
                        return False
                    else:
                        rows[i].add(board[i][j])
                        cols[j].add(board[i][j])
                        boxes[box].add(board[i][j])
            return True
        