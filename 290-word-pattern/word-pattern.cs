public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] t = s.Split(' ');
        if (pattern.Length != t.Length) return false;
        
        var mapS = new Dictionary<char,int>();
        var mapT = new Dictionary<string,int>();
        int mS = 0;
        int mT = 0;
        for (int i = 0; i < pattern.Length; i++) {            
            var nS = mapS.Count;
            var nT = mapT.Count;

            var cS = pattern[i];
            var cT = t[i];
            //Console.WriteLine($"{cS}, {cT}");
            mS += mapS.ContainsKey(cS) ? mapS[cS] : nS;
            if (!mapS.ContainsKey(cS))
                mapS[cS] = nS;

            mT += mapT.ContainsKey(cT) ? mapT[cT] : nT;
            if (!mapT.ContainsKey(cT))
                mapT[cT] = nT;

            //Console.WriteLine($"{mS}, {mT}");

            if (mS != mT) return false;
        }
        
        return true;
    }
}