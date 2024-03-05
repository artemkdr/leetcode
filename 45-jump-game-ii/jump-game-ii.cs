public class Solution {
    public int Jump(int[] nums) {
        if (nums.Length == 1) return 0;
       
        int jumps = 0, curEnd = 0, curFarthest = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            curFarthest = Math.Max(curFarthest, i + nums[i]);
            if (i == curEnd)
            {
                jumps++;
                curEnd = curFarthest;
            }
        }
        return jumps;
    }

    
}