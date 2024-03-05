public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var dict = new Dictionary<int,int>();
        int n = 0;
        for (var i = 0; i < nums.Length; i++) {
            n = nums[i];
            if (dict.ContainsKey(n) && Math.Abs(i - dict[n]) <= k)
                return true;
            dict[n] = i;
        }
        return false;
    }
}