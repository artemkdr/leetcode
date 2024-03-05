public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;
        
        var mapS = new Dictionary<char,int>();
        var mapT = new Dictionary<char,int>();
        int mS = 0;
        int mT = 0;
        for (int i = 0; i < s.Length; i++) {            
            var nS = mapS.Count;
            var nT = mapT.Count;

            var cS = s[i];
            var cT = t[i];
            
            mS += mapS.ContainsKey(cS) ? mapS[cS] : nS;
            if (!mapS.ContainsKey(cS))
                mapS[cS] = nS;

            mT += mapT.ContainsKey(cT) ? mapT[cT] : nT;
            if (!mapT.ContainsKey(cT))
                mapT[cT] = nT;

            if (mS != mT) return false;
        }
        
        return true;
    }

    /*public string BuildMap(string str) {
        var map = new Dictionary<char,int>();
        string m = "";
        foreach (var c in str) {            
            var n = map.Count;
            //Console.WriteLine($"char = {c}, map count = {n}");
            m += "_" + (map.ContainsKey(c) ? map[c].ToString() : n.ToString());
            if (!map.ContainsKey(c))
                map[c] = n;
        }
        Console.WriteLine($"{str} = {m}");
        return m;
    }*/
}