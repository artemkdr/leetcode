public class Solution {
    public int MaxArea(int[] height) {
        int max = 0, n = height.Length, i = 0, j = n - 1;
        while (i < n && j > i) {
            int lh = height[i], rh = height[j], cmax = (j - i) * Math.Min(lh, rh);
            if (cmax > max) max = cmax;
            else if (lh <= rh) i++;
            else j--;
        }

        /*for (var i = 0; i < n; i++) {
            var lh = height[i];
            for (var j = n - 1; j > i; j--) {
                var h = Math.Min(lh, height[j]);
                var w = j - i;
                var cmax = w * h;
                // if this current max is less than found max then left height is already a minimum one,
                // then we can stop here, because it will not be greater on decreasing width
                if (cmax > max) {
                    max = cmax;
                } else if (lh <= height[j]) {
                    break;
                }
            }
        }*/
        return max;
    }
}