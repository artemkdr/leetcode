public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = Int32.MinValue;
        int currentSum = 0;
        for (int i = 0; i < nums.Length; i++) {
            currentSum += nums[i];
            if (currentSum > maxSum) maxSum = currentSum;
            if (currentSum < 0) currentSum = 0;
        }
        return maxSum;
    }
}