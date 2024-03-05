public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == val) {                                
                if (i < nums.Length - 1) {
                    for (int j = i + 1; j < nums.Length; j++) {
                        if (nums[j] != val) {
                            nums[i] = nums[j];
                            nums[j] = val;
                            k++;
                            break;
                        }
                    }
                }
            } else {
                k++;
            }
        }        
        return k;
    }
}