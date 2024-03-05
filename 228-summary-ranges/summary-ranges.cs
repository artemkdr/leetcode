public class Solution {
    public IList<string> SummaryRanges(int[] nums) {        
        var list = new List<string>();
        if (nums.Length == 0) return list;
        var sb = new StringBuilder(nums[0].ToString());        
        int prev = nums[0];
        bool seq = false;
        string arrow = "->";
        for (var i = 1; i < nums.Length; i++) {
            var n = nums[i];
            if (n == prev + 1) {
                seq = true;
            } else {
                if (seq) {
                    sb.Append(arrow);
                    sb.Append(prev.ToString());                
                }                
                list.Add(sb.ToString());
                sb.Clear();
                seq = false;
            }            
            if (sb.Length == 0) 
                sb.Append(n.ToString());
            prev = n;
        }
        if (seq) {
            sb.Append(arrow);
            sb.Append(prev.ToString());                
        }                
        list.Add(sb.ToString());
        return list;
    }
}