public class Solution {
    Dictionary<int,char> map = new Dictionary<int,char> {
        {1, 'I' },
        {5, 'V' },        
        {10, 'X' },
        {50, 'L' },
        {100, 'C' },
        {500, 'D' },
        {1000, 'M' }
    };

    public string IntToRoman(int num) {
        int r = 1;
        var s = new StringBuilder();
        while (num > 0) {            
            int right = num % 10 * r;            
            num = num / 10;  
            if (map.ContainsKey(right)) {
                s.Insert(0, map[right]);
            } else if (right == r * 9) {
                s.Insert(0, map[r].ToString() + map[r * 10].ToString());
            } else if (right == r * 4) {
                s.Insert(0, map[r].ToString() + map[r * 5].ToString());
            } else {
                int rr = right / r - 5;
                s.Insert(0, new string(map[r], rr > 0 ? rr : rr + 5));
                if (rr > 0) s.Insert(0, map[r * 5]); 
            }
            //Console.WriteLine("**** " + r + ", " + right + " -> " + s);
            r *= 10;                                   
        }
        return s.ToString();
    }
}