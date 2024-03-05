public class Solution {
    public int LengthOfLastWord(string s) {
        if (s.Length == 0) return 0;
        int len = 0;
        for (int i = s.Length - 1; i >= 0; i--) {
            if (s[i] == ' ') {
                if (len != 0)
                    break;
            } else {
                len++;
            }
        }
        return len;
    }

    public int LengthOfLastWord1(string s) {
        var arr = s.TrimEnd().Split(' ');
        if (arr.Length > 0)
            return arr[arr.Length - 1].Length;
        return 0;
    }
}