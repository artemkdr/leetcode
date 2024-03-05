public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || numRows >= s.Length) return s;        
        var n = new StringBuilder();
        int row = 0;
        int col = 0;
        int speed = 1;
        int cols = 0;
        var dict = new Dictionary<int,List<char>>();
        for (int i = 0; i < s.Length; i++) {            
            if (!dict.ContainsKey(row)) dict[row] = new List<char>();            
            dict[row].Add(s[i]);
            row += speed;
            if (speed < 0) col++;
            if (row >= numRows - 1 || row <= 0) speed = - speed;
            cols = col;
        }
        for (int r = 0; r < numRows; r++) 
            n.Append(new string(dict[r].ToArray()));        
        return n.ToString();
    }
}