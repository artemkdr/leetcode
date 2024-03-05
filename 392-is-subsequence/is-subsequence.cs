public class Solution {
    static public Dictionary<string,Dictionary<char,List<int>>> mapST = new Dictionary<string,Dictionary<char,List<int>>>();    

    public bool IsSubsequence(string s, string t) {
        if (s.Length > t.Length) return false;
        var mapT = mapST.ContainsKey(t) ? mapST[t] : new Dictionary<char,List<int>>();
        if (!mapST.ContainsKey(t)) {
            for (var i = 0; i < t.Length; i++) {
                var c = t[i];
                if (!mapT.ContainsKey(c)) mapT[c] = new List<int>();
                mapT[c].Add(i);
            }
            mapST[t] = mapT;
        }
        int lastPos = -1;
        for (var i = 0; i < s.Length; i++) {
            var c = s[i];
            if (!mapT.ContainsKey(c))
                return false;
            var list = mapT[c];
            bool found = false;
            foreach (var j in list) {
                if (j > lastPos) {
                    lastPos = j;
                    found = true;
                    break;
                }
            }
            if (!found)
                return false;
        }
        return true;
    }
}