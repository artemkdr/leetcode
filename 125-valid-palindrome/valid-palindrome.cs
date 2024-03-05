public class Solution {
    public bool IsPalindrome(string s) {
        var sb = new StringBuilder();
        foreach (char c in s) {
            if (Char.IsLetterOrDigit(c)) {
                sb.Append(Char.ToLower(c));
            }
        }
        var arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        return sb.ToString() == new string(arr);
    }

    public bool IsPalindrome1(string s) {
        var s1 = System.Text.RegularExpressions.Regex.Replace(s, @"[^a-zA-Z0-9]+", "").ToLower();                
        var arr = s1.ToCharArray();
        Array.Reverse(arr);
        //Console.WriteLine(s1);
        //Console.WriteLine(new string(arr));
        return s1 == (new string(arr));
    }
}