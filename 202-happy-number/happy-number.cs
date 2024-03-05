public class Solution {
    public bool IsHappy(int n) {
        int num = GetNum(n);
        int i = 0;
        HashSet<int> nums = new HashSet<int>();
        while (num != 1) {
            num = GetNum(num);
            if (nums.Contains(num)) break;
            nums.Add(num);            
            i++;
        }        
        return num == 1;
    }    

    int GetNum(int n ) {
        var chiffres = n.ToString().ToCharArray();
        int num = 0;
        foreach (var c in chiffres) {
            num += (int)Math.Pow(Char.GetNumericValue(c), 2);
        }
        return num;
    }
}