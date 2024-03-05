public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var list = new List<List<string>>();
        var map = new Dictionary<string,List<string>>();
        for (var i = 0; i < strs.Length; i++) {
            var m = GetMapFor(strs[i]);
            if (!map.ContainsKey(m)) {
                map[m] = new List<string>();
            }
            map[m].Add(strs[i]);
        }        
        return map.Select(x => x.Value).ToArray();
    }

    static Dictionary<string,string> MAP = new Dictionary<string,string>();

    public string GetMapFor(string s) {
        if (MAP.ContainsKey(s)) return MAP[s];
        var l = new List<char>(s.ToCharArray());
        l.Sort();        
        MAP[s] = new string(l.ToArray());
        return MAP[s];
    }
}