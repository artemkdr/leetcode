public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        char[] toConstruct = ransomNote.ToCharArray();
        List<char> letters = new List<char>(magazine.ToCharArray());
        foreach (var c in toConstruct) {
            if (!letters.Contains(c))
                return false;
            letters.Remove(c);
        }
        return true;
    }
}