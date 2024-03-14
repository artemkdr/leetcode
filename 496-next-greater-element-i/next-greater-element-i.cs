public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] ans = new int[nums1.Length];
        var map = new Dictionary<int,int>();
        var map1 = new Dictionary<int,int>();
        int prevMin = Int32.MaxValue;;
        for (int i = 0; i < nums2.Length; i++) {
            map[nums2[i]] = i;
            if (nums2[i] > prevMin && prevMin >= 0) {
                map1[prevMin] = nums2[i];
                prevMin = nums2[i];
            } else {
                prevMin = Math.Min(prevMin, nums2[i]);
            }
            if (i == nums2.Length - 1) {
                map1[nums2[i]] = -1;
            }
        }
        for (int i = 0; i < nums1.Length; i++) {
            var el = nums1[i];
            int gr = -1;
            if (map1.ContainsKey(el)) {
               gr = map1[el]; 
            } else {
                var k = map[el];                
                for (var j = k + 1; j < nums2.Length; j++) {
                    if (nums2[j] > el) {
                        gr = nums2[j];
                        break;
                    }
                }
            }
            ans[i] = gr;
        }
        return ans;
    }
}