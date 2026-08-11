public class Solution {
      public bool IsValidSudoku(char[][] board) {
        Dictionary <int,HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
        Dictionary <int,HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
        Dictionary <(int,int),HashSet<char>> box = new Dictionary<(int,int), HashSet<char>>();
        
        for(int i=0;i < board.Length; i++)
            {
                for(int j=0; j < board[i].Length; j++)
                {
                    if(board[i][j] != '.'){
                    if(!rows.ContainsKey(i)) rows.Add(i,new HashSet<char>());
                    if(rows[i].Contains(board[i][j])) return false;
                    else rows[i].Add(board[i][j]);

                    if(!cols.ContainsKey(j)) cols.Add(j,new HashSet<char>());
                    if(cols[j].Contains(board[i][j])) return false;
                    else cols[j].Add(board[i][j]);
                    
                    
                    int X=i/3;
                    int Y=j/3;

                    if(!box.ContainsKey((X,Y))) box.Add((X,Y),new HashSet<char>{board[i][j]});
                    else if(box[(X,Y)].Contains(board[i][j])) return false;
                    else box[(X,Y)].Add(board[i][j]);
                    }
                }
            }
            return true;
    }
}
