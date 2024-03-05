public class Solution {
    public bool IsValid(string s) {
        if (s == null || s.Length == 0) return true;
        char P1 = '(', P2 = ')', B1 = '{', B2 = '}', S1 = '[', S2 = ']';        
        var lastOpenBracket = new StringBuilder();        
        foreach (var c in s) {
            if (c == B2 || c == P2 || c == S2) {
                if (lastOpenBracket.Length <= 0) 
                    return false;
                else {                    
                    var lb = lastOpenBracket[lastOpenBracket.Length - 1];
                    if (c == B2 && lb != B1 || 
                        c == P2 && lb != P1 || 
                        c == S2 && lb != S1) 
                        return false;
                    lastOpenBracket.Length--;
                }                
            } else if (c == B1 || c == P1 || c == S1)
                lastOpenBracket.Append(c);
        }        
        return lastOpenBracket.Length == 0;
    }
}