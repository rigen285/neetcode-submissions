public class Solution {
     public bool IsValidSudoku(char[][] board) {
            var rows= new Dictionary<int, HashSet <char>>();
            var cols = new Dictionary<int, HashSet <char>>();
            Dictionary<(int,int),HashSet<char>> boxes = new Dictionary<(int,int), HashSet<char>>();
            
            

            for(int i =0; i < board.Length; i++)
            {
                for (int j=0; j < board[i].Length; j++)
                {
                    char ch = board[i][j];
                    int x = i/3;
                    int y = j/3;

                    if (ch == '.') continue;

                    if (!boxes.ContainsKey((x, y)))
                    {
                        boxes[(x,y)] = new HashSet <char>(); 
                    }
                    if (!rows.ContainsKey(i))
                    {
                        rows[i] =  new HashSet <char>();
                    }
                    if (!cols.ContainsKey(j))
                    {
                        cols[j] =  new HashSet <char>();
                    }

                    if(!rows[i].Add(ch) || !cols[j].Add(ch) || !boxes[(x, y)].Add(ch))
                    {
                        return false;
                    }
                }
            }   

            return true; 
    }

}
