public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        List<string> rslt = new List<string>();
        StringBuilder str = new StringBuilder();
        Char space = ' ';
        for (int i = 0; i < words.Length; i++) {
            string word = words[i];
            if (str.Length == 0) {
                str.Append(word);
            } else {
                if (str.Length + 1 + word.Length > maxWidth) {
                    // start to justify
                    rslt.Add(str.ToString());
                    str = new StringBuilder(word);                
                } else {
                    str.Append(space);
                    str.Append(word);
                }
            }
        }
        if (str.Length > 0)
            rslt.Add(str.ToString());
        FillWithSpaces(rslt, maxWidth);
        return rslt;
    }

    void FillWithSpaces(List<string> list, int width) {
        Char space = ' ';
        for (int i = 0; i < list.Count; i++) {
            string s = list[i];
            var words = s.Split(space);
            int index = 0;            
            while (s.Length < width) {
                if (i == list.Count - 1) index = words.Length - 1;
                words[index++] += space;
                s = String.Join(space, words);
                if (index > words.Length - 2) index = 0;                
            }
            list[i] = s;
        }
    }
}