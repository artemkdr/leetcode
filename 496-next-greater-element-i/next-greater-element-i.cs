public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] ans = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++) {
            var el = nums1[i];
            var k = Array.IndexOf(nums2, el);
            var gr = -1;
            for (var j = k + 1; j < nums2.Length; j++) {
                if (nums2[j] > el) {
                    gr = nums2[j];
                    break;
                }
            }
            ans[i] = gr;
        }
        return ans;
    }
}