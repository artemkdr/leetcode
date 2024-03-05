public class Solution {
    public string ReverseWords(string s) {
        var ns = new StringBuilder();        
        var arr = s.Split(' ');
        for (var i = arr.Length - 1; i >= 0; i--) {
            if (arr[i].Length > 0) {                
                ns.Append(arr[i]);
                ns.Append(' ');                
            }
        }        
        if (ns.Length > 0)
            ns.Length--;
        return ns.ToString();
    }
}