public class Solution {
    public string LongestCommonPrefix(string[] strs) {                
        if (strs.Length == 1) return strs[0];
        StringBuilder s = new StringBuilder();
        for (var l = 0; l < strs[0].Length; l++) {
            bool br = false;
            for (var i = 1; i < strs.Length; i++) {
                if (strs[0].Length <= l || strs[i].Length <= l || strs[i][l] != strs[0][l]) {
                    br = true;
                    break;                
                }
            }
            if (!br)
                s.Append(strs[0][l]);                
            else
                break;
        }
        return s.ToString();
    }
}