public class Solution {
    Dictionary<string,int> map = new Dictionary<string,int>() {
        { "I", 1 },
        { "IV", 4 },
        { "IX", 9 },
        { "V", 5 },
        { "X", 10 },
        { "XL", 40 },
        { "XC", 90 },
        { "L", 50 },
        { "C", 100 },
        { "CD", 400 },
        { "CM", 900 },
        { "D", 500 },
        { "M", 1000 }
    };

    public int RomanToInt(string s) {
        int roman = 0;
        bool notCoupled = true;
        for (int i = 0; i < s.Length; i++) {
            char c1 = s[i];
            notCoupled = true;
            //Console.WriteLine("----- " + i);
            if (i < s.Length - 1) {
                char c2 =  s[i + 1];    
                string cc = new string(new char[] { c1, c2 });
                if (map.ContainsKey(cc)) {                    
                    notCoupled = false;
                    roman += map[cc];
                    //Console.WriteLine("" + cc + " = " + map[cc]);
                    //Console.WriteLine("" + roman);
                    i++;
                }
            }
            if (notCoupled)
                roman += map[c1.ToString()];            
        }
        return roman;
    }
}