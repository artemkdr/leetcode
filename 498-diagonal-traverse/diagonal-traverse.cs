public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) {        
        int m = mat.Length, n = mat[0].Length, x = 0, y = 0, dir = -1;
        var rslt = new int[n * m];
        int stage = 0; // 0 - jump, 1 - go through
        for (int i = 0; i < m * n; i++) {           
            rslt[i] = mat[x][y];        
            if (stage == 0) {
                stage = m == 1 || n == 1 ? 0 : 1;
                if (x == 0 || x == m - 1) {
                    if (y < n - 1) y += 1;
                    else x += 1;
                    dir = -dir;
                } else if (y == 0 || y == n - 1) {
                    if (x < m - 1) x += 1;
                    else y += 1;
                    dir = -dir;
                }
            } else {
                x += dir;
                y -= dir;
                if (x <= 0 || x >= m - 1 || y <= 0 || y >= n - 1) {
                    stage = 0;                   
                }
            }
        }
        return rslt.ToArray();
    }
}