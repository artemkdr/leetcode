public class Solution {
    public int MajorityElement(int[] nums) {
        if (nums.Length == 1) return nums[0];        
        int n = nums.Length;        
        int nn = n % 2 == 0 ? n / 2 : n / 2 + 1;        
        int m = Int32.MinValue;
        int count = 0;
        int others = 0;
        HashSet<int> skipNums = new HashSet<int>();
        for (int i = 0; i < n; i++) {
            count = 1;            
            m = nums[i];
            if (skipNums.Contains(m)) continue;
            if (others >= nn - 1) 
                return m;
            for (int j = i + 1; j < n; j++) {
                if (skipNums.Contains(nums[j])) continue;
                if (nums[j] == m) {
                    count++;
                    if (count >= nn) 
                        return m;                    
                }
                if (count + (n - j) < nn)
                    break;
            }             
            if (count >= nn) 
                return m;           
            skipNums.Add(m);
            others += count;                  
        }
        return m;
    }

    public int MajorityElement1(int[] nums) {
        if (nums.Length == 1) return nums[0];        
        int n = nums.Length;        
        int nn = n % 2 == 0 ? n / 2 : n / 2 + 1;        
        Dictionary<int,int> map = new Dictionary<int,int>();
        int m = Int32.MinValue;
        for (int i = 0; i < n; i++) {
            int e = nums[i];
            map[e] = map.ContainsKey(e) ? map[e] + 1 : 1;
            if (m < map[e]) {
                m = e;
            }
            //Console.WriteLine("** " + e + ", " + map[e]);
            if (map[e] >= nn) {
                m = e;
                return m;
            }
        }
        return m;
    }
}