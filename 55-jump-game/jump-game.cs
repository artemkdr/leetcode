public class Solution {
    public bool CanJump(int[] nums) {
        if (nums.Length == 1) return true;
        int reach = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (reach < i) return false;
            reach = Math.Max(reach, i + nums[i]);
        }
        return true;
    }

    public bool CanJump1(int[] nums) {
        // array to store results
        int[] dp = new int[nums.Length];        
        // recursion        
        bool rslt = check(nums, 0, dp);
        Console.WriteLine("*** " + count);
        return rslt;
    }

    int count = 0;

    public bool check(int[] nums, int index, int[] dp) {
        // successfull end
        if (index >= nums.Length - 1) return true;
        // failed
        if (nums[index] == 0) return false;

        // if already done then return from the saved results
        if (dp[index] != 0) return dp[index] == 2;

        // next index
        int nextIndex = nums[index] + index;
        // and check it for every index in between
        for (int i = index + 1; i <= nextIndex; i++) {
            count++;
            // just check additionaly that it's on already overlapping
            if (i <= nums.Length - 1 && check(nums, i, dp)) {
                // store result
                dp[i] = 2;
                return true;
            }
        }
        
        // store result
        dp[index] = 1;
        return false;
    }

    public bool CanJump2(int[] nums) {
        if (nums.Length == 1) return true;
        
        var n = nums.Length;
        int reach = 0;
        for (var i = 0; i < n; i++) {            
            if (reach < i) return false;
            reach = Math.Max(reach, i + nums[i]);
        }       
        return true;
    }
}