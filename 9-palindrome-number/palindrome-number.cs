public class Solution {
    public bool IsPalindrome(int x) {
        if (x >= 0) {
            var s1 = x.ToString();
            var arr = s1.ToCharArray();
            Array.Reverse(arr);
            var s2 = new string(arr);
            return s1 == s2;
        }
        return false;
    }
}