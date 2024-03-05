public class Solution {
    public int LongestConsecutive(int[] nums) {
        int l = 0, n = 0, len = nums.Length, count = 0;
        var dict = new Dictionary<int,int[]>();
        for (var i = 0; i < len; i++) {
            n = nums[i];
            dict[n] = new int[2] { i, i };            
            if (dict.ContainsKey(n - 1)) {                
                dict[n - 1][1] = i;                
            }
            if (dict.ContainsKey(n + 1)) {
                dict[n][1] =  dict[n + 1][0];                
            }            
        }        
        Dictionary<int,int> done = new Dictionary<int,int>();
        int[] d;
        foreach (var k in dict.Keys) {
            if (done.ContainsKey(k)) continue;
            d = dict[k];
            count = 1;
            while (d[0] != d[1]) {
                n = nums[d[1]];
                if (done.ContainsKey(n)) {
                    count += done[n];
                    break;
                }                
                count++;
                done[n] = count;                
                d = dict[n];
            }
            done[k] = count;
            if (count > l) l = count;
        }
        //Console.WriteLine($"nums length = {len}, iterations = {iterations}");
        return l;
    }
}