public class Solution {
    public int HammingWeight(uint n) {
        var arr = Convert.ToString(n, 2);
        int count = 0;
        foreach (var c in arr) 
            if (c == '1') count++;
        return count;
    }
}