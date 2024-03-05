public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var n = nums.Length;
        var arr = new int[n];  
        var p = 1;        
        int zeros = 0;
        for (int i = 0; i < n; i++) {                        
            if (nums[i] == 0) zeros++;
            if (zeros >= 2) break;
            arr[i] = p;
            p *= nums[i];            
        }
        p = 1;
        for (int i = n - 1; i >= 0; i--) {
            if (zeros >= 2) {
                arr[i] = 0;
            } else {
                arr[i] *= p;
                p *= nums[i];
            }
        }
        
        return arr;
    }
    public int[] ProductExceptSelf1(int[] nums) {
        var n = nums.Length;
        var arr = new int[n];
        int product = arr[0];
        bool hasZero = false;
        for (int i = 0; i < n; i++) {
            var p = 1;
            if (nums[i] == 0) {
                hasZero = true;
            } else if (hasZero) {
                arr[i] = 0;
                continue;
            }
            for (int j = 0; j < n; j++) {
                if (i == j) continue;
                p *= nums[j];
                if (p == 0) break;                
            }
            arr[i] = p;
        }
        return arr;
    }
}