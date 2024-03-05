public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var map = new Dictionary<char,int>();
        for (var i = 0; i < s.Length; i++) {
            var c = s[i];                
            map[c] = map.ContainsKey(c) ? map[c] + 1 : 1;
            //Console.WriteLine($"{c}, {map[c]}");
        }
        foreach (var c in t) {
            if (!map.ContainsKey(c) || map[c] <= 0) return false;
            map[c]--;
        }
        return true;
    }
}