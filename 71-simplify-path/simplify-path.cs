public class Solution {
    public string SimplifyPath(string path) {
        if (path.Length == 1) return path;
        var s = new StringBuilder();
        var points = new StringBuilder();
        Stack<int> slashes = new Stack<int>();
        for (int i = 0; i < path.Length; i++) {
            var c = path[i];            
            switch (c) {
                case '/':
                    if (s.Length > 0 && s[s.Length - 1] == '/' || i == path.Length - 1) {
                        // ignore
                    } else {                        
                        s.Append(c);
                        slashes.Push(s.Length);                        
                    }                   
                    break;
                case '.':
                    points.Clear();
                    bool purePoints = s.Length == 0 || s[s.Length - 1] == '/';                     
                    while (c != '/') {
                        points.Append(c);
                        purePoints &= c == '.';
                        if (i >= path.Length - 1) break;
                        c = path[++i];
                    }
                    if (!purePoints || points.Length > 2) {
                        s.Append(points);
                        if (c == '/') {
                            s.Append(c);
                            slashes.Push(s.Length);
                        }
                    } else if (purePoints && points.Length == 2 && slashes.Count > 0) {
                        var cnt = slashes.Count;
                        int rmv = cnt > 1 ? 2 : 1;
                        var s1 = slashes.Pop();
                        s.Length = slashes.Count > 0 ? slashes.Pop() : s1;
                        slashes.Push(s.Length);
                    }
                    break;
                default:
                    s.Append(c);
                    break;
            }            
        }
        if (s.Length > 1 && s[s.Length - 1] == '/') s.Length--;
        return s.ToString();
    }
}