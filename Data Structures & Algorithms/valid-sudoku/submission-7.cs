public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary <int,HashSet<char>>rows = new Dictionary <int,HashSet<char>>();
        Dictionary <int,HashSet<char>>cols = new Dictionary <int,HashSet<char>>();
        Dictionary <(int,int),HashSet<char>>box = new Dictionary <(int,int),HashSet<char>>();

        for(int i=0; i<9;i++)
        {
            for(int j=0; j<9;j++)
            {
                if(board[i][j]== '.') continue;

                if(!rows.ContainsKey(i)){
                    rows[i] = new HashSet<char>();
                }
                if(!cols.ContainsKey(j)){
                    cols[j] = new HashSet<char>();
                }

                
                int x = i/3;
                int y = j/3;

                if(!box.ContainsKey((x,y))){
                    box[(x,y)] = new HashSet<char>();
                }



                if(!rows[i].Add(board[i][j]) || !cols[j].Add(board[i][j]) || !box[(x,y)].Add(board[i][j]))
                {
                    return false;
                }

            }
            
        }

        return true;
    }
}
