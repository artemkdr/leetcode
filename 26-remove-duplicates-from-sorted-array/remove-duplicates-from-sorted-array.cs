public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 1;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}