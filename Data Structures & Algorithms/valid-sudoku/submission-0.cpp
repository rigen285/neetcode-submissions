class Solution {
public:
    bool isValidSudoku(vector<vector<char>>& board) {
        vector <unordered_set <char>> row(9),column(9),boxes(9);

        int rows =9;
        int columns =9;

        for(int i=0; i<rows; i++){
            for(int j=0; j<columns; j++){
                char ch = board[i][j];
                if (ch == '.') {continue;}

                int num = (i / 3) * 3 + (j / 3);

                if(row[i].count(ch)||column[j].count(ch)||boxes[num].count(ch)){
                    return false;
                }

                row[i].insert (ch);
                column[j].insert(ch);
                boxes[num].insert(ch);

            }
        }

        return true;
    }
};
